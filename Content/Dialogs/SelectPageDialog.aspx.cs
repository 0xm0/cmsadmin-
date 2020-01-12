#region License and copyright notice
/* 
 * R161 Content Management System
 * 
 * Copyright (c) Fredrik Schultz
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3.0 of the License, or (at your option) any later version.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * Lesser General Public License for more details.
 * http://www.gnu.org/licenses/lgpl-3.0.html
 */
#endregion

namespace R161CMS.Admin.Content.Dialogs {
    using R161CMS.Extensions;
    using System;

    public partial class SelectPageDialog : System.Web.UI.Page {
        
        protected void Page_Load(object sender, EventArgs e) {
            string pageId = Request.QueryString["pageId"];
            Guid currentPageId = Guid.Empty;

            if(!string.IsNullOrEmpty(pageId)) {
                pageId.TryParseGuid(out currentPageId);
            }

            CurrentPage = currentPageId;
        }

        protected Guid CurrentPage { get; set; }
    }
}