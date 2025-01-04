using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OgrenciYonetimSistemi.Data;
using OgrenciYonetimSistemi.Models;
using OgrenciYonetimSistemi.Models.Entities;
using System;
using System.Linq;

namespace universitydb.Controllers
{
    [Authorize(Roles = "Sekreter")] // Sekreter rolünü doğrulama
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Dependency Injection ile AppDbContext'i alıyoruz
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        
    }
}
