﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TongYan.Web.Controls.Tree;

namespace TongYan.Web.Controls
{
    public interface IWebControlWrapper<TEntity>
    {
        /// <summary>
        /// 生成Tree
        /// </summary>
        /// <param name="id">Tree id</param>
        /// <returns>ITreeApi</returns>
        ITreeApi Tree(string id);
    }
}
