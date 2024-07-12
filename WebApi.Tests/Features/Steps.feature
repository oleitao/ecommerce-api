Feature: WebApi.Tests
		Web APi to get categories

A short summary of the feature

@mytag
Scenario: Categories.GetCategories
	Given the repository has 'categories' data
	When I make a GET request to 'categories'
	Then the response status code is '200'
	And the response json should be 'categories.json'

Scenario: Categories.GetCategoryById
	Given the repository has 'categories' data
	When I make a GET request with id '6e27b4b8-e66c-450a-bf41-58344b208512' to 'categories'
	Then the response status code is '200'
	And the response json should be 'category.json'

Scenario: Categories.AddCategory
	Given the repository has 'categories' data
	When I make a POST request with 'category.json' to 'categories'
	Then the response status code is '201'

Scenario: Categories.UpdateCategory
	Given the repository has 'categories' data
	When I make a PUT request with '6e27b4b8-e66c-450a-bf41-58344b208512' to 'categories'
	Then the response status code is '200'
	And the response entity should be 'category.json'
	
Scenario: Categories.RemoveCategory
	Given the repository has 'categories' data
	When I make a DELETE request with id '6e27b4b8-e66c-450a-bf41-58344b208513' to 'categories'
	Then the response status code is '204'


Scenario: ImageUrls.GetImageurls
	Given the repository has 'imageurls' data
	When I make a GET request to 'imageurls'
	Then the response status code is '200'
	And the response json should be 'imageurls.json'

Scenario: ImageUrls.GetImageUrlById
	Given the repository has 'imageurls' data
	When I make a GET request with id '1b129a29-08a4-4597-8708-092f202bd123' to 'imageurls'
	Then the response status code is '200'
	And the response json should be 'imageurl.json'

Scenario: ImageUrls.AddImageUrl
	Given the repository has 'imageurls' data
	When I make a POST request with 'imageurl.json' to 'imageurls'
	Then the response status code is '201'

Scenario: ImageUrls.UpdateImageUrl
	Given the repository has 'imageurls' data
	When I make a PUT request with '1b129a29-08a4-4597-8708-092f202bd123' to 'imageurls'
	Then the response status code is '200'
	And the response entity should be 'imageurl.json'
	
Scenario: ImageUrls.RemoveImageUrl
	Given the repository has 'imageurls' data
	When I make a DELETE request with id '48366c80-fd5f-421e-8a43-9f2fa65c0ba2' to 'imageurls'
	Then the response status code is '204'


Scenario: Reviews.GetReviews
	Given the repository has 'reviews' data
	When I make a GET request to 'reviews'
	Then the response status code is '200'
	And the response json should be 'reviews.json'

Scenario: Reviews.GetReviewById
	Given the repository has 'reviews' data
	When I make a GET request with id 'a1c922f3-95a9-45aa-a45c-d573166852ce' to 'reviews'
	Then the response status code is '200'
	And the response json should be 'review.json'

Scenario: Reviews.AddReview
	Given the repository has 'reviews' data
	When I make a POST request with 'review.json' to 'reviews'
	Then the response status code is '201'

Scenario: Reviews.UpdateReview
	Given the repository has 'reviews' data
	When I make a PUT request with 'a1c922f3-95a9-45aa-a45c-d573166852ce' to 'reviews'
	Then the response status code is '200'
	And the response entity should be 'review.json'
	
Scenario: Reviews.RemoveReview
	Given the repository has 'reviews' data
	When I make a DELETE request with id 'a1c922f3-95a9-45aa-a45c-d573166852ce' to 'reviews'
	Then the response status code is '204'


Scenario: ShopAvatars.GetShopAvatars
	Given the repository has 'shopavatars' data
	When I make a GET request to 'shopavatars'
	Then the response status code is '200'
	And the response json should be 'shopavatars.json'

Scenario: ShopAvatars.GetShopAvatarById
	Given the repository has 'shopavatars' data
	When I make a GET request with id '41635d09-6c09-40cd-89c5-17f81ab497fc' to 'shopavatars'
	Then the response status code is '200'
	And the response json should be 'shopavatar.json'

Scenario: ShopAvatars.AddShopAvatar
	Given the repository has 'shopavatars' data
	When I make a POST request with 'shopavatar.json' to 'shopavatars'
	Then the response status code is '201'

Scenario: ShopAvatars.UpdateShopAvatar
	Given the repository has 'shopavatars' data
	When I make a PUT request with '41635d09-6c09-40cd-89c5-17f81ab497fc' to 'shopavatars'
	Then the response status code is '200'
	And the response entity should be 'shopavatar.json'
	
Scenario: ShopAvatars.RemoveShopAvatar
	Given the repository has 'shopavatars' data
	When I make a DELETE request with id '77b918f2-b0b9-443d-9961-2bb969b3609c' to 'shopavatars'
	Then the response status code is '204'


Scenario: Shops.GetShops
	Given the repository has 'shops' data
	When I make a GET request to 'shops'
	Then the response status code is '200'
	And the response json should be 'shops.json'

Scenario: Shops.GetShopById
	Given the repository has 'shops' data
	When I make a GET request with id 'c2264d48-6f36-4b1a-bf95-3c62f67f2ac0' to 'shops'
	Then the response status code is '200'
	And the response json should be 'shop.json'

Scenario: Shops.AddShop
	Given the repository has 'shops' data
	When I make a POST request with 'shop.json' to 'shops'
	Then the response status code is '201'

Scenario: Shops.UpdateShop
	Given the repository has 'shops' data
	When I make a PUT request with 'c2264d48-6f36-4b1a-bf95-3c62f67f2ac0' to 'shops'
	Then the response status code is '200'
	And the response entity should be 'shop.json'
	
Scenario: Shops.RemoveShop
	Given the repository has 'shops' data
	When I make a DELETE request with id 'c2264d48-6f36-4b1a-bf95-3c62f67f2ac0' to 'shops'
	Then the response status code is '204'


Scenario: Users.GetUsers
	Given the repository has 'users' data
	When I make a GET request to 'users'
	Then the response status code is '200'
	And the response json should be 'users.json'

Scenario: Users.GetUserById
	Given the repository has 'users' data
	When I make a GET request with id 'efbcf454-0125-41ff-ac91-75d1564af044' to 'users'
	Then the response status code is '200'
	And the response json should be 'user.json'

Scenario: Users.AddUser
	Given the repository has 'users' data
	When I make a POST request with 'user.json' to 'users'
	Then the response status code is '201'

Scenario: Users.UpdateUser
	Given the repository has 'users' data
	When I make a PUT request with 'efbcf454-0125-41ff-ac91-75d1564af044' to 'users'
	Then the response status code is '200'
	And the response entity should be 'user.json'
	
Scenario: Users.RemoveUser
	Given the repository has 'users' data
	When I make a DELETE request with id 'efbcf454-0125-41ff-ac91-75d1564af045' to 'users'
	Then the response status code is '204'