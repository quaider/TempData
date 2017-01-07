﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TongYan.Web.Controls.Tree;

namespace TongYan.Web.Controls
{
    public class WebControlWrapper<TEntity> : IWebControlWrapper<TEntity>
    {
        private readonly HtmlHelper<TEntity> _helper;

        public WebControlWrapper(HtmlHelper<TEntity> helper)
        {
            _helper = helper;
        }

        public ITreeApi Tree(string id)
        {
            return new TreeControl(id, _helper.ViewContext);
        }
    }
}
