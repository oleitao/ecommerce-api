
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


------------------------------------------------------------------------------------------------------------------------------------
POST(https://localhost:64403/api/products)
{
    "Category": {
        "id": "afaf0968-4d52-4c91-cbaf-08dc7ce3e375",
        "title": "N/A",
        "subTitle": "test",
        "imageUrl": "https://searchspring.com"
    },
    "ImageURLs": [
        {
            "id": "2b36c506-8a20-41e8-8faf-02b1df746104",
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



TESTS
https://github.com/kashifsoofi/blog-code-samples/tree/main/integration-test-sqlserver-dotnet