using System;
using Microsoft.AspNetCore.mvc;
using DoaçõesApp.Data;
using doaçõesApp.Models;

namespace SistemaONG.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly AppContext _context;
        public CategoriaController(AppContext context)
        {
            _context = context;
        }
        // GET: Categoria
        public IActionResult Index()
        {
            var categorias = _context.Categorias.ToList();
            return View(categorias);
        }
        // GET: Categoria/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var categoria = _context.Categorias.FirstOrDefault(m => m.Id == id);
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }
        // GET: Categoria/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Categoria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Nome,Descricao")] Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoria);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(categoria);
        }