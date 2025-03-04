using Microsoft.AspNetCore.Mvc;
using ETicaretSitesi.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ETicaretSitesi.Controllers
{
    public class ProductsController : Controller
    {
        private readonly List<Product> products = new List<Product>
        {
            new Product
            {
                ProductID = 1,
                ProductName = "Classic Spring",
                ShortDescription = "Classic men's wear",
                LongDescription = "A great classic wear for spring.",
                Price = 120.00m,
                Quantity = 10,
                Size = "M",
                Color = "Blue",
                CompanyName = "Spring Co.",
                CategoryId = 1, // Men's Category
                SubCategoryId = 1,
                IsActive = true,
                CreateDate = DateTime.Now,
                ImageUrl = "men-01.jpg",
                ProductImages = new List<ProductImages>
                {
                    new ProductImages { ImageID = 1, ImageUrl = "men-01.jpg", ProductId = 1, DefaultImage = true },
                    new ProductImages { ImageID = 2, ImageUrl = "men-01-back.jpg", ProductId = 1, DefaultImage = false }
                }
            },
            new Product
            {
                ProductID = 2,
                ProductName = "Air Force 1 X",
                ShortDescription = "Casual shoes",
                LongDescription = "Stylish and comfortable casual shoes.",
                Price = 90.00m,
                Quantity = 15,
                Size = "42",
                Color = "White",
                CompanyName = "Nike",
                CategoryId = 1, // Men's Category
                SubCategoryId = 2,
                IsActive = true,
                CreateDate = DateTime.Now,
                ImageUrl = "men-02.jpg",
                ProductImages = new List<ProductImages>
                {
                    new ProductImages { ImageID = 3, ImageUrl = "men-02.jpg", ProductId = 2, DefaultImage = true },
                    new ProductImages { ImageID = 4, ImageUrl = "men-02-back.jpg", ProductId = 2, DefaultImage = false }
                }
            },
            new Product
            {
                ProductID = 3,
                ProductName = "Denim Jacket",
                ShortDescription = "Casual jacket",
                LongDescription = "Stylish and comfortable casual jacket.",
                Price = 100.00m,
                Quantity = 15,
                Size = "126",
                Color = "White",
                CompanyName = "Mavi",
                CategoryId = 1, // Men's Category
                SubCategoryId = 3,
                IsActive = true,
                CreateDate = DateTime.Now,
                ImageUrl = "men-03.jpg",
                ProductImages = new List<ProductImages>
                {
                    new ProductImages { ImageID = 3, ImageUrl = "men-03.jpg", ProductId = 3, DefaultImage = true },
                    new ProductImages { ImageID = 4, ImageUrl = "men-03-back.jpg", ProductId = 3, DefaultImage = false }
                }
            },
            new Product
            {
                ProductID = 4,
                ProductName = "SweatShirt",
                ShortDescription = "Casual jacket",
                LongDescription = "Stylish and comfortable casual shoes.",
                Price = 130.00m,
                Quantity = 15,
                Size = "XL",
                Color = "brown",
                CompanyName = "Mavi",
                CategoryId = 1, // Men's Category
                SubCategoryId = 4,
                IsActive = true,
                CreateDate = DateTime.Now,
                ImageUrl = "Resim1.png",
                ProductImages = new List<ProductImages>
                {
                    new ProductImages { ImageID = 4, ImageUrl = "Resim1.png", ProductId = 4, DefaultImage = true },
                    new ProductImages { ImageID = 5, ImageUrl = "swaearka.png", ProductId = 4, DefaultImage = false }
                }
            },
            new Product
            {
                ProductID = 5,
                ProductName = "Sweat Dress",
                ShortDescription = "Exclusive clothing",
                LongDescription = "Exclusive wear for special occasions.",
                Price = 130.00m,
                Quantity = 5,
                Size = "L",
                Color = "Red",
                CompanyName = "Nana Inc.",
                CategoryId = 2, // Women's Category
                SubCategoryId = 5,
                IsActive = true,
                CreateDate = DateTime.Now,
                ImageUrl = "women-03.jpg",
                ProductImages = new List<ProductImages>
                {
                    new ProductImages { ImageID = 6, ImageUrl = "women-03.jpg", ProductId = 5, DefaultImage = true }
                }
            },
            new Product
            {
                ProductID = 6,
                ProductName = "Love Nana '20",
                ShortDescription = "Exclusive clothing",
                LongDescription = "Exclusive wear for special occasions.",
                Price = 150.00m,
                Quantity = 5,
                Size = "L",
                Color = "Red",
                CompanyName = "Nana Inc.",
                CategoryId = 2, // Women's Category
                SubCategoryId = 6,
                IsActive = true,
                CreateDate = DateTime.Now,
                ImageUrl = "women-01.jpg",
                ProductImages = new List<ProductImages>
                {
                    new ProductImages { ImageID = 6, ImageUrl = "women-01.jpg", ProductId = 6, DefaultImage = true }
                }
            },
            new Product
            {
                ProductID = 7,
                ProductName = "Dress",
                ShortDescription = "Exclusive clothing",
                LongDescription = "Exclusive wear for special occasions.",
                Price = 180.00m,
                Quantity = 5,
                Size = "L",
                Color = "Red",
                CompanyName = "Nana Inc.",
                CategoryId = 2, // Women's Category
                SubCategoryId = 7,
                IsActive = true,
                CreateDate = DateTime.Now,
                ImageUrl = "women-02.jpg",
                ProductImages = new List<ProductImages>
                {
                    new ProductImages { ImageID = 7, ImageUrl = "women-02.jpg", ProductId = 7, DefaultImage = true }
                }
            },
            new Product
            {
                ProductID = 8,
                ProductName = "Women Hat",
                ShortDescription = "Exclusive clothing",
                LongDescription = "Exclusive wear for special occasions.",
                Price = 200.00m,
                Quantity = 5,
                Size = "L",
                Color = "Red",
                CompanyName = "Nana Inc.",
                CategoryId = 2, // Women's Category
                SubCategoryId = 8,
                IsActive = true,
                CreateDate = DateTime.Now,
                ImageUrl = "swaearka.png",
                ProductImages = new List<ProductImages>
                {
                    new ProductImages { ImageID = 8, ImageUrl = "swaearka.png", ProductId = 8, DefaultImage = true }
                }
            },
            new Product
            {
                ProductID = 9,
                ProductName = "School Collection",
                ShortDescription = "Perfect for kids",
                LongDescription = "Ideal collection for school-going kids.",
                Price = 80.00m,
                Quantity = 8,
                Size = "One Size",
                Color = "Yellow",
                CompanyName = "Kids Co.",
                CategoryId = 3, // Kids' Category
                SubCategoryId = 9,
                IsActive = true,
                CreateDate = DateTime.Now,
                ImageUrl = "kid-01.jpg",
                ProductImages = new List<ProductImages>
                {
                    new ProductImages { ImageID = 9, ImageUrl = "kid-01.jpg", ProductId = 9, DefaultImage = true }
                }
            },
            new Product
            {
                ProductID = 10,
                ProductName = "School Kids Collection",
                ShortDescription = "Perfect for kids",
                LongDescription = "Ideal collection for school-going kids.",
                Price = 140.00m,
                Quantity = 8,
                Size = "One Size",
                Color = "Yellow",
                CompanyName = "Kids Co.",
                CategoryId = 3, // Kids' Category
                SubCategoryId = 10,
                IsActive = true,
                CreateDate = DateTime.Now,
                ImageUrl = "kid-02.jpg",
                ProductImages = new List<ProductImages>
                {
                    new ProductImages { ImageID = 10, ImageUrl = "kid-02.jpg", ProductId = 10, DefaultImage = true }
                }
            },
            new Product
            {
                ProductID = 11,
                ProductName = "Kids Collection",
                ShortDescription = "Perfect for kids",
                LongDescription = "Ideal collection for school-going kids.",
                Price = 140.00m,
                Quantity = 8,
                Size = "One Size",
                Color = "Yellow",
                CompanyName = "Kids Co.",
                CategoryId = 3, // Kids' Category
                SubCategoryId = 11,
                IsActive = true,
                CreateDate = DateTime.Now,
                ImageUrl = "kid-03.jpg",
                ProductImages = new List<ProductImages>
                {
                    new ProductImages { ImageID = 11, ImageUrl = "kid-03.jpg", ProductId = 11, DefaultImage = true }
                }
            }
        };

        public ProductsController() { }

        // Method to get a product by ID
        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.ProductID == id);
        }

        // Get all products
        public List<Product> GetAllProducts()
        {
            return products;
        }

        // Get products by CategoryId
        public List<Product> GetProductsByCategory(int categoryId)
        {
            return products.Where(p => p.CategoryId == categoryId).ToList();
        }

        // Get products by SubCategoryId
        public List<Product> GetProductsBySubCategory(int subCategoryId)
        {
            return products.Where(p => p.SubCategoryId == subCategoryId).ToList();
        }

        // Display all products
        public IActionResult Products()
        {
            return View(products);
        }

        // Display product details
        public IActionResult Details(int id)
        {
            var product = GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            product.Category = new Category { CategoryID = product.CategoryId, CategoryName = "Category " + product.CategoryId };
            product.SubCategory = new SubCategory { SubCategoryID = product.SubCategoryId, SubCategoryName = "SubCategory " + product.SubCategoryId };

            TempData["PreviousProductId"] = id;
            return View(product);
        }
        // Kategoriye göre ürünleri listeleme
        [HttpGet("Products/Category/{categoryId}")]
        public IActionResult Category(int categoryId)
        {
            var categoryProducts = products.Where(p => p.CategoryId == categoryId).ToList();

            if (!categoryProducts.Any())
                return NotFound("Bu kategoriye ait ürün bulunamadı.");

            ViewBag.CategoryName = categoryId == 1 ? "Men" :
                                   categoryId == 2 ? "Women" :
                                   categoryId == 3 ? "Kids" : "Other";

            return View(categoryProducts);
        }
    }
}
