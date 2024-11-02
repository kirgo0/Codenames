using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CodenamesWeb.Components.Icons
{
    public abstract class Icon : IconBase
    {
        private protected sealed override RenderFragment Body => BuildRenderTree;

        // Allow content to be provided by a .razor file but without 
        // overriding the content of the base class
        protected new virtual void BuildRenderTree(RenderTreeBuilder builder)
        {
        }
    }
}
