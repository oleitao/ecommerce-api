
set up the ASPNETCORE_ENVIRONMENT environment variable

can set the variable through the command prompt by typing set ASPNETCORE_ENVIRONMENT=Production in Windows or export ASPNET_CORE_ENVIRONMENT=Production in Linux


https://github.com/luciansr/dotnet-core-mysql-boilerplate

dotnet ef migrations add initial

dotnet ef database update


DATA
https://jsonformatter.curiousconcept.com/#
https://www.convertcsv.com/json-to-csv.htm?utm_content=cmp-true




https://localhost:64403/api/v1/categories
https://localhost:64403/api/categories/6e27b4b8-e66c-450a-bf41-58344b208512/products


https://learn.microsoft.com/pt-pt/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio


ROUTE
https://code-maze.com/aspnetcore-pass-parameters-to-http-get-action/


TESTS
https://docs.specflow.org/projects/getting-started/en/latest/GettingStarted/Step6.html

------------------------------------------------------------------------------------------------------------------------------------
GetCategoriesOptions
OPTIONS(https://localhost:64403/api/categories)
------------------------------------------------------------------------------------------------------------------------------------
GetAllProducts
HEAD(https://localhost:64403/api/products)
------------------------------------------------------------------------------------------------------------------------------------


------------------------------------------------------------------------------------------------------------------------------------


------------------------------------------------------------------------------------------------------------------------------------
FilterUserMinAgeSort
GET(https://localhost:64403/api/users/filter?orderBy=FullName asc)
FilterProductsSorted
GET(https://localhost:64403/api/products/filter?orderBy=Name desc)
------------------------------------------------------------------------------------------------------------------------------------
FilterUserMinAge
GET(https://localhost:64403/api/users/filter?minAge=37)
GET(https://localhost:64403/api/users/filter?maxAge=37)
------------------------------------------------------------------------------------------------------------------------------------
FilterUserMinAge
GET(https://localhost:64403/api/users/filter?searchTerm=M)
GET(https://localhost:64403/api/users/filter?minAge=36&searchTerm=P)
------------------------------------------------------------------------------------------------------------------------------------
GetPagedProductsForCategory
GET(https://localhost:64403/api/categories/6E27B4B8-E66C-450A-BF41-58344B208512/products?minName=10)
------------------------------------------------------------------------------------------------------------------------------------
GetPagedProductsForCategory
GET(https://localhost:64403/api/categories/6E27B4B8-E66C-450A-BF41-58344B208512/products?pageNumber=2&pageSize=5)
------------------------------------------------------------------------------------------------------------------------------------
GetPagingProductsForCategory
GET(https://localhost:64403/api/categories/6E27B4B8-E66C-450A-BF41-58344B208512/products?pageNumber=2&pageSize=5)
------------------------------------------------------------------------------------------------------------------------------------
CreateProductForCategory
POST(https://localhost:64403/api/categories/FE58DDC2-61EE-4E1A-9402-A0C9EBFB8E5C/products)
{
    "Category": {
        "id": "fe58ddc2-61ee-4e1a-9402-a0c9ebfb8e5c",
        "title": "Others",
        "subTitle": "",
        "imageUrl": ""
    },
    "ImageUrls": [
        {
            "id": "2b36c506-8a20-41e8-8faf-0661df746104",
            "publicUrl": "test",
            "url": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg7XWy1cmt1D3uUjF29eo2q4HgqJaGEu9XDg&usqp=CAU"
        },
        {
            "id": "2b36c506-8a20-41e8-8faf-02b11f746104",
            "publicUrl": "test",
            "url": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg7XWy1cmt1D3uUjF29eo2q4HgqJaGEu9XDg&usqp=CAU"
        }
    ],
    "Reviews": [
        {
            "userId": "f3d2300a-c9cf-49b4-b137-aca949bf3b6a",
            "comment": "comment",
            "rating": 5
        }
    ],
    "name": "produto teste",
    "description": "descrição.",
    "price": 0,
    "discount_Price": 0,
    "rating": 0,
    "total_Sell": 0,
    "stock": 0
}
------------------------------------------------------------------------------------------------------------------------------------
CreateCategoryCollection
GET(https://localhost:64403/api/categories/collection)
[
    {
        "id": "4d9ea93c-1b54-4576-9821-0822f8c32aa0",
        "title": "TEST1",
        "subTitle": "",
        "imageUrl": "https://static.vecteezy.com/system/resources/previews/011/996/555/original/3d-black-headphone-illustration-ecommerce-icon-png.png"
    },
    {
        "id": "4d9ea93c-1b54-4576-9821-0822f8c32UU0",
        "title": "TEST2",
        "subTitle": "",
        "imageUrl": "https://static.vecteezy.com/system/resources/previews/011/996/555/original/3d-black-headphone-illustration-ecommerce-icon-png.png"
    }
]
------------------------------------------------------------------------------------------------------------------------------------
GetProductsByCategory
GET(https://localhost:64403/api/categories/6E27B4B8-E66C-450A-BF41-58344B208512/products)
------------------------------------------------------------------------------------------------------------------------------------
GetCategoryCollection
GET(https://localhost:64403/api/categories/collection/(4D9EA93C-1B54-4576-9821-0822F8C32EE0,418A55C2-6254-4BC7-9593-4A41665FD396))
------------------------------------------------------------------------------------------------------------------------------------
UpdateCategory
PUT(https://localhost:64403/api/categories/418A55C2-6254-4BC7-9593-4A41665FD396)
{
    "title": "TEST3",
    "subTitle": "test put",
    "imageUrl": "https://static.vecteezy.com/system/resources/previews/011/996/555/original/3d-black-headphone-illustration-ecommerce-icon-png.png"
}
------------------------------------------------------------------------------------------------------------------------------------
DeleteImageUrl
DELETE(https://localhost:64403/api/imageurls/2B36C506-8A20-41E8-8FAF-02B1DF746104)
------------------------------------------------------------------------------------------------------------------------------------
PartiallyUpdateProductForCompany
PATCH(https://localhost:64403/api/categories/FC7F2981-1031-4D10-8565-9CF93F211799/products/B4087A37-1862-4408-A52B-2F06D122D540)
[
    {
        "op": "replace",
        "path": "/description",
        "value": ""
    }
]
------------------------------------------------------------------------------------------------------------------------------------

------------------------------------------------------------------------------------------------------------------------------------

------------------------------------------------------------------------------------------------------------------------------------

TESTS
https://github.com/kashifsoofi/blog-code-samples/tree/main/integration-test-sqlserver-dotnet