SELECT p.[Name], c.[Name]
FROM Product p
LEFT JOIN ProductCategoryMapping pc 
    ON p.ID = pc.ProductID
LEFT JOIN Category c 
    ON pc.CategoryID = c.ID
ORDER BY p.[Name], c.[Name];