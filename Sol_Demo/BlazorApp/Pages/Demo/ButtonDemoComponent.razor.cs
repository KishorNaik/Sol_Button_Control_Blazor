using Button;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages.Demo
{
    public partial class ButtonDemoComponent
    {
        #region Private Button reference

        private ButtonComponent ButtonRed { get; set; }

        private ButtonComponent ButtonGreen { get; set; }

        private ButtonComponent ButtonBlue { get; set; }

        #endregion Private Button reference

        #region Private Property

        private String DisplayText { get; set; }

        #endregion Private Property

        #region Public Event Handler

        public void OnBlueButtonClickEventHandler(MouseEventArgs mouseEventArgs)
        {
            DisplayText = "Blue Button Click";
        }

        public void OnGreenButtonClickEventHandler(MouseEventArgs mouseEventArgs)
        {
            DisplayText = "Green Button Click";
        }

        public void OnRedButtonClickEventHandler(MouseEventArgs mouseEventArgs)
        {
            DisplayText = "Red Button Click";
        }

        #endregion Public Event Handler
    }
}