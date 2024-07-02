
set up the ASPNETCORE_ENVIRONMENT environment variable

can set the variable through the command prompt by typing set ASPNETCORE_ENVIRONMENT=Production in Windows or export ASPNET_CORE_ENVIRONMENT=Production in Linux


https://github.com/luciansr/dotnet-core-mysql-boilerplate

dotnet ef migrations add initial

dotnet ef database update


DATA
https://jsonformatter.curiousconcept.com/#
https://www.convertcsv.com/json-to-csv.htm?utm_content=cmp-true




https://localhost:5000/api/v1.1/v1/categories
https://localhost:5000/api/v1.1/categories/6e27b4b8-e66c-450a-bf41-58344b208512/products


https://learn.microsoft.com/pt-pt/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio


ROUTE
https://code-maze.com/aspnetcore-pass-parameters-to-http-get-action/


TESTS
https://docs.specflow.org/projects/getting-started/en/latest/GettingStarted/Step6.html

DOCKER
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d


https://www.freecodecamp.org/news/how-to-set-an-environment-variable-in-linux/
SET ENVIRIONMENT KEY
setx SECRET "43443FDFDF34DF34343fdf344SDFSDFSDFSDFSDF4545354345SDFGDFGDFGDFGdffgfdGDFGDGR%" /M


REDIS
https://redis.io/learn/develop/dotnet/aspnetcore/caching/basic-api-caching
https://nishanc.medium.com/redis-as-a-distributed-cache-on-net-6-0-949ef5b795ee
https://www.c-sharpcorner.com/article/caching-mechanism-in-asp-net-core/


SQLSERVER TO MYSQL
dotnet ef migrations add InitialMigration
dotnet ef database update
//In some situations I recommend clear DB by next command before first migration:
dotnet ef database -f

------------------------------------------------------------------------------------------------------------------------------------
GetAllProducts
GetProductById
GET(https://localhost:5000/api/v1.1/products/398E76BB-70F0-4712-AF76-10726BB6DD92)
{
    "id": "398e76bb-70f0-4712-af76-10726bb6dd92",
    "name": "MacBook pro M2 chipset 256gb ssd 8gb ram space-gray color with apple 1 year warranty",
    "description": "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
    "price": 0,
    "discount_price": 0,
    "rating": 0,
    "total_sell": 0,
    "stock": 0,
    "categoryId": "6e27b4b8-e66c-450a-bf41-58344b208512",
    "shopId": "c2264d48-6f36-4b1a-bf95-3c62f67f2ac0",
    "category": {
        "id": "6e27b4b8-e66c-450a-bf41-58344b208512",
        "title": "Computers and Laptops",
        "subTitle": "",
        "imageUrl": "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838"
    },
    "image_Url": [],
    "reviews": [
        {
            "id": "dc3a92ce-1c3c-40c8-8266-9e0d638d236b",
            "comment": "comment",
            "rating": 5,
            "userId": "efbcf454-0125-41ff-ac91-75d1564af044",
            "productId": "398e76bb-70f0-4712-af76-10726bb6dd92"
        }
    ],
    "shop": {
        "id": "c2264d48-6f36-4b1a-bf95-3c62f67f2ac0",
        "name": "Apple inc",
        "ratings": 4,
        "shopAvatarId": "41635d09-6c09-40cd-89c5-17f81ab497fc",
        "shopAvatar": {
            "id": "41635d09-6c09-40cd-89c5-17f81ab497fc",
            "public_id": "test",
            "url": "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png",
            "shopId": "00000000-0000-0000-0000-000000000000"
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------

------------------------------------------------------------------------------------------------------------------------------------

------------------------------------------------------------------------------------------------------------------------------------
UpdateImageUrl
PUT(https://localhost:5000/api/v1.1/imageurls/337dad38-f567-46f4-bf2c-00ad96e08299)
{
    "public_id": "PUT method test",
    "url": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR42FePhUrLX424aLie09J4Pfkn03T8h3D7PQ&usqp=CAU",
    "productId": "00000000-0000-0000-0000-000000000000"
}
------------------------------------------------------------------------------------------------------------------------------------
UpdateCategory
PUT(https://localhost:5000/api/v1.1/categories/00000000-0000-0000-0000-000000000000)
{
    "title": "New Category 1",
    "subTitle": "",
    "imageUrl": "https://example.com"
}
------------------------------------------------------------------------------------------------------------------------------------
CreateImageUrlAsync
POST(https://localhost:5000/api/v1.1/imageurls)
{
    "publicUrl": "test",
    "url": "http://example.com",
    "productId": "B8E3A7B5-286C-406D-B05D-BB45EB6EF953"
}
------------------------------------------------------------------------------------------------------------------------------------
CreateReview
POST(https://localhost:5000/api/v1.1/reviews)
{
    "comment": "comment test",
    "rating": 5,
    "userId": "d645a5fa-f628-41dd-99d1-6776984bfe91",
    "productId": "DCA64784-3EB3-4C8A-96B4-0B7FA930FDCF"
}
------------------------------------------------------------------------------------------------------------------------------------
CreateImageUrlAsync
POST(https://localhost:5000/api/v1.1/imageurls)
{
    "publicUrl": "api-test",
    "url": "https://example.com",
    "ProductId": "97107600-0846-40C6-921A-4DB12253B008"
}
------------------------------------------------------------------------------------------------------------------------------------
CreateShopAvatar
POST(https://localhost:5000/api/v1.1/shopavatars)
{
    "publicId": "api-test",
    "url": "https://example.com"
}
------------------------------------------------------------------------------------------------------------------------------------
CreateCategory
POST(https://localhost:5000/api/v1.1/categories)
{
    "title": "New Category 2",
    "subTitle": "",
    "imageUrl": "https://example.com"
}
------------------------------------------------------------------------------------------------------------------------------------
https://localhost:5000/swagger/index.html?urls.primaryName=E-Commerce+WebAPI+v1
------------------------------------------------------------------------------------------------------------------------------------
DeleteCategory
DELETE(https://localhost:5000/api/v1.1/categories/F02D00B6-54BB-4E48-BC43-FC9CD3DEF502)
------------------------------------------------------------------------------------------------------------------------------------
GetCategoriesOptions
OPTIONS(https://localhost:5000/api/v1.1/categories)
------------------------------------------------------------------------------------------------------------------------------------
GetAllProducts
HEAD(https://localhost:5000/api/v1.1/products)
------------------------------------------------------------------------------------------------------------------------------------
RegisterUser
POST(https://localhost:5000/api/v1.1/authentication)
{
    "firstname": "oliveira",
    "lastname": "leitao",
    "fullname": "oliveira leitao",
    "username": "oleitao",
    "password": "Password1000",
    "email": "oleitao@gmail.com",
    "phonenumber": "589-654",
    "gender": "M",
    "hobby": "netflix",
    "roles": [
        "Manager"
    ]
}}
------------------------------------------------------------------------------------------------------------------------------------
Authenticate
POST(https://localhost:5000/api/v1.1/authentication/login)
{
    "username": "oleitao",
    "password": "Password1000"
}
------------------------------------------------------------------------------------------------------------------------------------
Refresh
POST(https://localhost:5000/api/v1.1/authentication/refresh)
{
    "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoib2xlaXRhbyIsImV4cCI6MTcxODE3ODcxOCwiaXNzIjoiV2ViQXBpIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMSJ9.Dh-bbiYkBprWo8zWYgy1Z8XOjdkQ81zZuGcWeY8g3BA",
    "refreshToken": "PVKT/VXyaBsVeOiUaFd1u4CNFCN0bPp9uC2FYdQQFGM="
}
------------------------------------------------------------------------------------------------------------------------------------
FilterUserMinAgeSort
GET(https://localhost:5000/api/v1.1/users/filter?orderBy=FullName asc)
FilterProductsSorted
GET(https://localhost:5000/api/v1.1/products/filter?orderBy=Name desc)
------------------------------------------------------------------------------------------------------------------------------------
FilterUserMinAge
GET(https://localhost:5000/api/v1.1/users/filter?minAge=37)
GET(https://localhost:5000/api/v1.1/users/filter?maxAge=37)
------------------------------------------------------------------------------------------------------------------------------------
FilterUserMinAge
GET(https://localhost:5000/api/v1.1/users/filter?searchTerm=M)
GET(https://localhost:5000/api/v1.1/users/filter?minAge=36&searchTerm=P)
------------------------------------------------------------------------------------------------------------------------------------
GetPagedProductsForCategory
GET(https://localhost:5000/api/v1.1/categories/6E27B4B8-E66C-450A-BF41-58344B208512/products?minName=10)
------------------------------------------------------------------------------------------------------------------------------------
GetPagedProductsForCategory
GET(https://localhost:5000/api/v1.1/categories/6E27B4B8-E66C-450A-BF41-58344B208512/products?pageNumber=2&pageSize=5)
------------------------------------------------------------------------------------------------------------------------------------
GetPagingProductsForCategory
GET(https://localhost:5000/api/v1.1/categories/6E27B4B8-E66C-450A-BF41-58344B208512/products?pageNumber=2&pageSize=5)
------------------------------------------------------------------------------------------------------------------------------------
CreateProductForCategory
POST(https://localhost:5000/api/v1.1/categories/FE58DDC2-61EE-4E1A-9402-A0C9EBFB8E5C/products)
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
GET(https://localhost:5000/api/v1.1/categories/collection)
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
GET(https://localhost:5000/api/v1.1/categories/6E27B4B8-E66C-450A-BF41-58344B208512/products)
------------------------------------------------------------------------------------------------------------------------------------
GetCategoryCollection
GET(https://localhost:5000/api/v1.1/categories/collection/(4D9EA93C-1B54-4576-9821-0822F8C32EE0,418A55C2-6254-4BC7-9593-4A41665FD396))
------------------------------------------------------------------------------------------------------------------------------------
UpdateCategory
PUT(https://localhost:5000/api/v1.1/categories/418A55C2-6254-4BC7-9593-4A41665FD396)
{
    "title": "TEST3",
    "subTitle": "test put",
    "imageUrl": "https://static.vecteezy.com/system/resources/previews/011/996/555/original/3d-black-headphone-illustration-ecommerce-icon-png.png"
}
------------------------------------------------------------------------------------------------------------------------------------
DeleteImageUrl
DELETE(https://localhost:5000/api/v1.1/imageurls/2B36C506-8A20-41E8-8FAF-02B1DF746104)
------------------------------------------------------------------------------------------------------------------------------------
PartiallyUpdateProductForCompany
PATCH(https://localhost:5000/api/v1.1/categories/FC7F2981-1031-4D10-8565-9CF93F211799/products/B4087A37-1862-4408-A52B-2F06D122D540)
[
    {
        "op": "replace",
        "path": "/description",
        "value": ""
    }
]
------------------------------------------------------------------------------------------------------------------------------------
Authenticate
POST(https://localhost:5000/api/v1.1/authentication/login)
{
    "username": "oleitao",
    "password": "Password1000"
}
------------------------------------------------------------------------------------------------------------------------------------

------------------------------------------------------------------------------------------------------------------------------------

TESTS
https://github.com/kashifsoofi/blog-code-samples/tree/main/integration-test-sqlserver-dotnet