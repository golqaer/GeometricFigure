/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT p.Title as ProductTitle, c.Title as CategoryTitle
  FROM Products as p
left join CategoryProduct as cp on cp.ProductsId=p.Id
left join Categories as c on c.Id=cp.CategoriesId