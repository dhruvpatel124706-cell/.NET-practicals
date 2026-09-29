namespace ProductCatalogMVC.Models

{

public class Product

{

public int Id { get; set; }

public string Name { get; set; }

public double Price { get; set; }

public string Category { get; set; }

}

}

using System.Collections.Generic;

using System.Web.Mvc;

using ProductCatalogMVC.Models;

namespace ProductCatalogMVC.Controllers

{

public class ProductController : Controller

{

public ActionResult Index()

{

List<Product> products = new List<Product>()

{

new Product

{

Id = 1,

Name = "Laptop",

Price = 55000,

Category = "Electronics"

},

new Product

{

Id = 2,

Name = "Mobile",

Price = 25000,

Category = "Electronics"

},

new Product

{

Id = 3,

Name = "Headphones",

Price = 2000,

Category = "Accessories"

};

}

return View(products);

public ActionResult Details(int id)

}

{

Product product = new Product();

if (id == 1)

{

product = new Product

{

Id = 1,

Name = "Laptop",

Price = 55000,

Category = "Electronics"

};

else if (id == 2)

}

{

product = new Product

{

Id = 2,

Name = "Mobile",

Price = 25000,

Category = "Electronics"

};

}

else

{

product = new Product

{

Id = 3,

Name = "Headphones",

Price = 2000,

Category = "Accessories"

};

}

return View(product);

}

}

}

@model IEnumerable<ProductCatalogMVC.Models.Product>

<!DOCTYPE html>

<html>

<head>

<title>Product Catalog</title>

<style>

body {

font-family: Arial;

margin: 40px;

}

table {

width: 80%;

border-collapse: collapse;

}

th, td {

border: 1px solid black;

padding: 10px;

text-align: left;

}

th {

background-color: lightgray;

}

h1 {

color: darkblue;

}

</style>

</head>

<body>

<h1>Product Catalog</h1>

<table>

<tr>

<th>ID</th>

<th>Product Name</th>

<th>Price</th>

<th>Category</th>

<th>Action</th>

</tr>

@foreach (var product in Model)

{

<tr>

<td>@product.Id</td>

<td>@product.Name</td>

<td>₹@product.Price</td>

<td>@product.Category</td>

<td>

@Html.ActionLink(

"Details",

"Details",

new { id = product.Id })

</td>

</tr>

}

</table>

</body>

</html>





