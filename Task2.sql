SELECT Products.Name as 'Product Name', ISNULL(Categories.Name, 'No category') as 'Category Name'
FROM Products
LEFT JOIN ProductCategory ON Products.ID = ProductCategory.Product_ID
LEFT JOIN Categories ON ProductCategory.Category_ID = Categories.ID;