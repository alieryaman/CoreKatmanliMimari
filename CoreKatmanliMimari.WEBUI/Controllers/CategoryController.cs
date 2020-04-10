using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreKatmanliMimari.Business.Abstract;
using CoreKatmanliMimari.WEBUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreKatmanliMimari.WEBUI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult GetCategories()
        {
            var categoryViewModel = new CategoryViewModel
            {
                Categories = _categoryService.GetList()
            };
            return View(categoryViewModel);
        }
    }

}