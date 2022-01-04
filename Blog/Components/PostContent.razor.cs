using Microsoft.AspNetCore.Components;
using Markdig;
using Microsoft.JSInterop;
//using Markdig.Prism;

namespace Blog.Components
{
    public partial class PostContent
    {
        #region Variables

        //private static readonly MarkdownPipeline MarkdownPipeline = new MarkdownPipelineBuilder()
        //    .UseAdvancedExtensions()
        //    .UsePrism()
        //    .Build();

        #endregion

        #region Injects

        [Inject]
        public IJSRuntime? JSRuntime { get; set; }

        #endregion

        #region Parameters

        [Parameter, EditorRequired]
        public Blog.Models.Post? Data { get; set; }

        [Parameter, EditorRequired]
        public string? Content { get; set; }

        public string MarkdownContent => Markdown.ToHtml(Content ?? string.Empty);

        #endregion

        #region Overrides

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync("highlightCode");
        }

        #endregion

    }
}