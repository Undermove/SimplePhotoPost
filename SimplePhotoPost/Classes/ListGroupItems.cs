﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimplePhotoPost.Models;
using SimplePhotoPost;

namespace SimplePhotoPost.Classes
{
    [Serializable]
    public class ListGroupItems
    {
        public List<ModelGroupItem> listGroupItem { get; set; }

        public ListGroupItems()
        { }
    }
}
