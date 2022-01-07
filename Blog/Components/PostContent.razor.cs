using Microsoft.AspNetCore.Components;
using Markdig;
using Microsoft.JSInterop;
//using Markdig.Prism;

namespace Blog.Components
{
    public partial class PostContent
    {
        #region Variables

        #endregion

        #region Injects

        [Inject]
        public IJSRuntime? JSRuntime { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        #endregion

        #region Parameters

        [Parameter, EditorRequired]
        public Blog.Models.Post? Data { get; set; }

        [Parameter, EditorRequired]
        public string? Content { get; set; }

        public string MarkdownContent => Markdown.ToHtml(Content ?? string.Empty);
        public string GetEditUrl => $"https://github.com/emimontesdeoca/blog/edit/main/Blog/wwwroot/posts/{Data?.Path}.md";
        public string GetTwitterUrl => $"https://twitter.com/intent/tweet?text={Data.Title} {NavigationManager.Uri}";

        #endregion

        #region Methods


        #endregion

        #region Overrides

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync("highlightCode");
        }

        #endregion

    }
}