using APP.SelfMadeComponents.ModalBoxes;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace APP.FunctionsUI
{
    public class ModalBox
    {
        public RenderFragment CreateComponent() => builder =>
        {
            for (var i = 0; i < 3; i++)
            {
                builder.OpenComponent(0, typeof(BaseModalBox));
                builder.AddContent(1, "<p>Ola Mundo</p>");
                builder.CloseComponent();
            }
        };
    }
}
