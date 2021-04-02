﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DriveTruck.Services;


namespace DriveTruck.Controllers
{
    public class CustomersController : Controller
    {
        private readonly CustomerServices _customerServices;

        public CustomersController(CustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        // GET: Customers
        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult Create()
        {
            return View();
        }


    }
}