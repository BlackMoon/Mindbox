USE SSISDB
GO

SELECT 
    ArticleName
    , TagName
	, CONVERT(VARCHAR, ArticleDate, 100) ArticleDate     	  
FROM Articles a
LEFT JOIN ArticleTags at ON at.ArticleId = a.ArticleId  
LEFT JOIN Tags t ON t.TagId = at.TagId

GO