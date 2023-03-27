using FlowerShop.Models.Interface;
using FlowerShop.Models.Service;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace FlowerShop.TagHelpers;
// You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
[HtmlTargetElement("categories", TagStructure = TagStructure.WithoutEndTag | TagStructure.NormalOrSelfClosing)]
public class CategoryTagHelper : TagHelper
{
    private readonly ICategoryService _categoryService;

    [ViewContext]
    [HtmlAttributeNotBound]
    public ViewContext viewContext { get; set; }


    private readonly IHtmlHelper _htmlHelper;

    public CategoryTagHelper(ICategoryService categoryService, IHtmlHelper htmlHelper)
    {
        _categoryService = categoryService;
        _htmlHelper = htmlHelper;
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        (_htmlHelper as IViewContextAware).Contextualize(viewContext);
        output.TagName = "";
        output.Content.SetHtmlContent(await _htmlHelper.PartialAsync( "TagHelpers/CategoryTagHelper/Index", _categoryService.GetCategory()));
    }
}
