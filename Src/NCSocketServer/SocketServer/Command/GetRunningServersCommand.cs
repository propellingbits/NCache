﻿// Copyright (c) 2017 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System;
using System.Collections.Generic;
using Alachisoft.NCache.Caching;

namespace Alachisoft.NCache.SocketServer.Command
{
    class GetRunningServersCommand : CommandBase
    {
        private struct CommandInfo
        {
            public string RequestId;
            public string CacheId;
            public bool IsDotNetClient;
        }

        //PROTOBUF
        public override void ExecuteCommand(ClientManager clientManager, Alachisoft.NCache.Common.Protobuf.Command command)
        {
            CommandInfo cmdInfo;
            try
            {
                cmdInfo = ParseCommand(command, clientManager);
            }
            catch (Exception exc)
            {
                if (!base.immatureId.Equals("-2"))
                    _serializedResponsePackets.Add(Alachisoft.NCache.Common.Util.ResponseHelper.SerializeExceptionResponse(exc, command.requestID));
                return;
            }

            Cache cache = null;

            try
            {
                string server = ConnectionManager.ServerIpAddress;
                int port = ConnectionManager.ServerPort;

                Dictionary<string, int> runningServers = new Dictionary<string, int>();
               
                cache = CacheProvider.Provider.GetCacheInstanceIgnoreReplica(cmdInfo.CacheId);

                if (cache == null) throw new Exception("Cache is not registered");
                if (!cache.IsRunning) throw new Exception("Cache is not running");
                
                runningServers = cache.GetRunningServers(server, port);
                Alachisoft.NCache.Common.Protobuf.Response response = new Alachisoft.NCache.Common.Protobuf.Response();
                Alachisoft.NCache.Common.Protobuf.GetRunningServersResponse getRunningServerResponse = new Alachisoft.NCache.Common.Protobuf.GetRunningServersResponse();

                if (runningServers != null)
                {
                    Dictionary<string, int>.Enumerator ide = runningServers.GetEnumerator();
                    while (ide.MoveNext())
                    {
                        Common.Protobuf.KeyValuePair pair = new Common.Protobuf.KeyValuePair();
                        pair.key = ide.Current.Key;
                        pair.value = ide.Current.Value.ToString();
                        getRunningServerResponse.keyValuePair.Add(pair);
                    }
                }
            

                response.requestId = Convert.ToInt64(cmdInfo.RequestId);
                response.getRunningServer = getRunningServerResponse;
                response.responseType = Alachisoft.NCache.Common.Protobuf.Response.Type.GET_RUNNING_SERVERS;

                _serializedResponsePackets.Add(Alachisoft.NCache.Common.Util.ResponseHelper.SerializeResponse(response));
            }
            catch (Exception exc)
            {
                _serializedResponsePackets.Add(Alachisoft.NCache.Common.Util.ResponseHelper.SerializeExceptionResponse(exc, command.requestID));
            }
        }

       
        //PROTOBUF
        private CommandInfo ParseCommand(Alachisoft.NCache.Common.Protobuf.Command command, ClientManager clientManager)
        {
            CommandInfo cmdInfo = new CommandInfo();

            Alachisoft.NCache.Common.Protobuf.GetRunningServersCommand getRunningServerCommand = command.getRunningServersCommand;

            cmdInfo.CacheId = getRunningServerCommand.cacheId;
            cmdInfo.IsDotNetClient = getRunningServerCommand.isDotnetClient;
            cmdInfo.RequestId = getRunningServerCommand.requestId.ToString();
            return cmdInfo;
        }
    }
}
