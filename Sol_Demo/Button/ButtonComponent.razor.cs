using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Text;

namespace Button
{
    public enum ButtonStyle
    {
        blue = 0,
        red = 1,
        green = 2
    };

    public partial class ButtonComponent
    {
        #region Public Parameter Property

        [Parameter]
        public ButtonStyle Styles { get; set; }

        [Parameter]
        public String Text { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnClickEventHandler { get; set; }

        #endregion Public Parameter Property

        #region Private Property

        private String StyleName { get; set; }

        #endregion Private Property
    }
}