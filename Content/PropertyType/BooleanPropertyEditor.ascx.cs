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

namespace R161CMS.Admin.Content.PropertyType {
    using System;
    using Core;
    using R161CMS.PropertyType;

    public partial class BooleanPropertyEditor : PropertyEditorBase {
        public override string PropertyLabel {
            set { LabelText.Text = value; }
        }

        public override PropertyData PropertyValue {
            get {
                return new BooleanProperty(ValueField.Checked);
            }
            set {
                var booleanProperty = (BooleanProperty) value;
                if (booleanProperty.ValueSet) {
                    ValueField.Checked = booleanProperty.Value;
                }
            }
        }

        public override string Parameters {
            set { throw new NotImplementedException(); }
        }

        public override bool Validate() {
            return true;
        }

        public override bool Validate(bool required) {
            return true;
        }
    }
}