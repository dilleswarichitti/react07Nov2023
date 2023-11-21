﻿using EventCalendarApp.Exceptions;
using EventCalendarApp.Interface;
using EventCalendarApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventCalendarApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            string errorMessage = string.Empty;
            try
            {
                var result = _categoryService.GetCategories();
                return Ok(result);
            }
            catch (NocategoriesAvailableException e)
            {
                errorMessage = e.Message;
            }
            return BadRequest(errorMessage);
        }
        [Authorize(Roles = "organizer")]
        [HttpPost]
        public ActionResult Create(Category category)
        {
            string errorMessage = string.Empty;
            try
            {
                var result = _categoryService.Add(category);
                return Ok(result);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
            return BadRequest(errorMessage);
        }
        /*[HttpPut]
         public ActionResult Update(Event events)
         {
             string errorMessage = string.Empty;
             try
             {
                 var result = _eventService.Update(events);
                 return Ok(events);
             }
             catch (EventsCantUpdateException e)
             {
                 errorMessage = e.Message;
             }
             return BadRequest(errorMessage);
         }*/

        /*[HttpDelete]
        public ActionResult Remove(Event events)
        {
            string errorMessage = string.Empty;
            try
            {
                var result = _categoryService.Remove(events);
                return Ok(events);
            }
            catch (EventsCantRemoveException e)
            {
                errorMessage = e.Message;
            }
            return BadRequest(errorMessage);
        }*/
    }
}
