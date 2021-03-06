﻿using System;
using LightImage.Networking.Services;

namespace LightImage.Networking.FileSharing
{
    public class FileSharePeer : ClusterShimPeer
    {
        public FileSharePeer(Guid id, string endpoint, Guid me, string role) : base(id, endpoint, me, role)
        {
        }
    }
}