﻿// Copyright (c) 2010 - OJ Reeves & Jeremiah Peschka
//
// This file is provided to you under the Apache License,
// Version 2.0 (the "License"); you may not use this file
// except in compliance with the License.  You may obtain
// a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

using CorrugatedIron.Messages;

namespace CorrugatedIron.Models.MapReduce
{
    public class RiakMapReduceResultPhase
    {
        public uint Phase { get; private set; }
        public byte[] Value { get; private set; }

        internal RiakMapReduceResultPhase(RpbMapRedResp result)
        {
            Phase = result.Phase;
            Value = result.Response;
        }
    }
}