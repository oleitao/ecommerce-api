using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: new Guid("2293b56b-e4d7-493c-b6cc-6359b1031322"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Discount_Price", "Name", "Price", "Rating", "Stock", "Total_Sell" },
                values: new object[,]
                {
                    { new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Kids Smart Watch,Boy Watch and Girls Watch Phone with Childrens Digital Camera Games Smart Alarm Clocks Music Player Calculator for 9 Year Olds Girls Boys As Birthday Toy Gifts or Cool Gadgets", 0, 0, 0, 0 },
                    { new Guid("014bd7bc-7fb5-41b2-8fdf-1da889568414"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Gaming Headphone Asus with mutiple color and free delivery", 0, 0, 0, 0 },
                    { new Guid("07817aa0-d85e-4250-8964-0ef6a64a62ba"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "New Trend shoes for gents with all sizes", 0, 0, 0, 0 },
                    { new Guid("0d4289de-a576-45d2-af10-f68fe0f47e64"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Immerse yourself in deep, booming sound that delivers a theater-like experience for movies, shows, and videos. Its four front speakers and Dolby Atmos® support deliver an immersive, cinematic experience.Every member of the family will have their own tailored—and secure—experience with the Tab P10. Each user gets their own account—accessible through a multi-user fingerprint reader—with individualized settings, wallpaper, and social media accounts.Since every member of the family gets their own account on the Tab P10, parents can make sure their kids stay safe. Secure the content your kids access and put time limits on their usage. The Tab P10 also boasts enhanced eye protection and easy-to-use voice search.", 0, "Lenovo Tab P10 | 10.1 Family Entertainment Tablet", 0, 0, 0, 0 },
                    { new Guid("17f1d840-1902-4903-85ae-7e69931a76b7"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "ZenBook Pro Duo 15 OLED lets you get things done in style: calmly, efficiently, and with zero fuss. Its your powerful and elegant next-level companion for on-the-go productivity and creativity, featuring an amazing 4K OLED HDR touchscreen. It also includes the tilting ASUS ScreenPad™ Plus secondary 4K display that offers effortless ergonomics and seamless workflows. Powered by up to an Intel® Core™ i9 14-core processor and NVIDIA® GeForce RTX™ 3070Ti GPU, ZenBook Pro Duo 15 OLED brings you all the benefits of tomorrows technology, today.", 0, "Zenbook Pro Duo 15 OLED (UX582, 12th Gen Intel)", 0, 0, 0, 0 },
                    { new Guid("247875c3-7244-4f84-a233-612b53d6bff4"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Samsung Galaxy S21 Ultra 5G is officially announced on January 14, 2021. The smartphone is pack with 12 GB and 16 GB RAM with 128 GB, 256 GB, 512 GB internal storage options. The device is built with a Glass front (Gorilla Glass Victus), a glass back (Gorilla Glass), and an aluminum frame. Samsung Galaxy S21 Ultra 5G is fueled with a non-removable Li-Po 5000 mAh battery + Fast charging 25W + USB Power Delivery 3.0 + Fast Qi/PMA wireless charging 15W + Reverse wireless charging 4.5W. The smartphone features a 6.8 inches Dynamic AMOLED 2X display that has a 1440 x 3200 pixels resolution. The device comes in Phantom Black, Phantom Silver, Phantom Titanium, Phantom Navy, and Phantom Brown. The smartphone consists of a quad-camera: 108 MP (wide) + 10 MP (periscope telephoto) + 10 MP (telephoto) + 12 MP (ultrawide) while on the front there is a 40 MP (wide). The sensors include Fingerprint (under display, ultrasonic), accelerometer, gyro, proximity, compass, and barometer.", 0, "Samsung S21 Ultra", 0, 0, 0, 0 },
                    { new Guid("24b6c01c-deb4-448a-88b4-bf73522fc9e2"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "We believe everyone, everywhere deserves healed skin. Thats why we created the Vaseline® Healing Project, to help people living in crisis and disaster care for their skin. Here, Vaseline® Jelly is a necessity. Our Essential Healing lotion, powered by the same extraordinary Vaseline® Jelly, deeply moisturizes to keep dry skin healed for 3 weeks.*Our unique formula includes pure oat extract and Vaseline® Jelly, without feeling greasy.Our revolutionary smart pump unlocks and locks with just a 90º turn - even in the raised position, with no mess.*Proven after 4 weeks daily use in a clinical study.Water, glycerin, stearic acid, isopropyl myristate, mineral oil, glyceryl stearate, glycol stearate, dimethicone, peg-100 stearate, petrolatum, cetyl alcohol, tapioca starch, phenoxyethanol, magnesium aluminum silicate, methylparaben, acrylates/c10-30 alkyl acrylate crosspolymer, fragrance, propylparaben, disodium EDTA, xanthan gum, stearamide amp, avena sativa (oat) straw extract, titanium dioxide (ci 77891).", 0, "Vaseline, Intensive Care, Essential Healing Body Lotion, 20.3 fl oz 600 ml", 0, 0, 0, 0 },
                    { new Guid("2854fd3f-5ffa-4444-aedc-33513495887b"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Latest Bluetooth 5.1 Technology-This Bluetooth headset adopts Bluetooth V5.1 standard, you can achieve faster and more stable transmission. The transmission distance is up to 10m (32.8ft) (without obstacles). Compatible with most Bluetooth-enabled devices, such as iPhone, Huawei, Samsung Galaxy, LG, Sony, PC, laptop, etc. It can also be used with 2 devices can be connected at the same time, so you can separate your life and work.Long Working Time-The wireless headset has been tested for up to 10 hours of continuous calls and music time. 180 hours standby time. Fulfill your calling needs while multitasking with amazingly crisp and clear sound. The cell phone Bluetooth headset features Type-C fast charging, which can provide 7 hours of face-to-face communication experience with a single 1-hour fast charge. Clear Sound & High Quality Audio-The wireless headphones with a CVC 8.State-of-the-art noise reduction, which produces a more natural, distortion-free sound quality and clear sound. Dual microphone is designed for calls, not only is it easy to hear other people, but also prevents the noise and sounds around you from being picked up, you can enjoy high quality music and clear phone calls. Comfortable Lightweight Design-The lightweight construction makes it the perfect headset for drivers or business people,The main body of the bluetooth headset weights only 12g (0.4oz), which will not cause any pain even if worn for a long time.Moreover The earhook can rotate 270 so you can adjust it to your preferred angle. small, medium and large Three optional ear tips ensure a comfortable fit for both left and right ears.Hands-free & Mute Button- The bluetooth hands-free headset is equipped with a multi-function button, you can play or pause music, answer/end/reject calls. You can also enable voice controls like Siri and Google Assistant. In addition, you can press the separate mute button for 2 seconds to activate/deactivate the microphone, protect your privacy when you need it.", 0, "Bluetooth Wireless Headset V5.1 Hands-free In-ear Hearphone With Microphone For Iphone Android", 0, 0, 0, 0 },
                    { new Guid("490252a0-7cae-4941-84f4-f9f8990b2486"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "MacBook pro M2 chipset 256gb ssd 8gb ram space-gray color with apple 1 year warranty", 0, 0, 0, 0 },
                    { new Guid("57ab32d3-4cec-422e-8f00-cadcdadb09b4"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure youre happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", 0, "LVSE Inside-Out T-Shirt", 0, 0, 0, 0 },
                    { new Guid("5de5e368-9b87-4070-9d72-2298bbfe92b8"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product 1: Do Check Partner offer section for Exciting offers from HP Product 1: Processor: Intel Core i3-1115G4 (up to 4.1 GHz with Intel Turbo Boost Technology(2g),6 MB L3 cache, 2 cores)|Memory: 8 GB DDR4-3200 SDRAM (1 x 8 GB)| Storage: 512 GB PCIe NVMe M.2 SSD Product 1: Display & Graphics : 39.6 cm (15.6) diagonal, FHD, micro-edge anti-glare, 250 nits, 141 ppi, 45%NTSC |Graphics: Intel UHD Graphics Product 1: Operating System & Preinstalled Software: Windows 11 Home 64 Plus Single Language | Microsoft Office Home & Student 2021| McAfee LiveSafe (30 days free trial as default) |Pre-installed Alexa built-in- Your life simplified with Alexa. Just ask Alexa to check your calendar, create to-do lists, shopping lists, play music, set reminders, get latest news and control smart home. Product 2: Stay unbound, stay in control - enjoy lag-free 2.4GHz wireless connectivity on this durable mouse by HP with an 18-month long battery life. Product 2: Work at your pace by speeding up or slowing down tracking with adjustable DPI settings up to 1600 (800/1200/1600). Product 2: Work on your terms with an ambidextrous, contoured design suitable for both left and right-hand use. Product 2: Enjoy great compatibility across devices and on different operating systems - Windows 10, Windows 8, Windows 7, and MacOS 10.1 or higher.", 0, "HP 15 Thin & Light Laptop (Intel i3 11th Gen/8GB RAM & 512GB SSD Storage/Win 11 Home + MS Office) X200 Wireless Mouse with 2.4 GHz Wireless connectivity and 18-Month Battery Life", 0, 0, 0, 0 },
                    { new Guid("6bc499e1-596b-4ebd-af19-10766d3fada5"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Onex 16 Bangles with Golden Stone Work for Women Casual Wear Traditional Golden Diamond Single Line Bangle Set for Girls Churi Set", 0, 0, 0, 0 },
                    { new Guid("72f3b8d9-45ff-4fe2-bd14-6651458aecf6"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "All Product Size: 15.5 Inch,16 Inch,16.5 Inch MOQ: 1 Set=3 Piece (1 from every size Fabrics Type=Fancy 100% cotton Color: As picture shown Main keywords: Mens Fancy Shirt wholesale", 0, "Cheap Price Mens Formal Shirt", 0, 0, 0, 0 },
                    { new Guid("79875154-f1ee-45ca-a90a-9a141dd6bb5b"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Trendy Shoes for Men With Great Comfortable. SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure you are happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", 0, "BRUTON Trendy Sports Shoes For Men (Blue)", 0, 0, 0, 0 },
                    { new Guid("833bb1db-1075-4b5e-a9ca-9c3991998224"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "3W Clinic Crystal White Milky Body Lotion is a skincare product that claims to brighten and moisturize the skin. It comes in a 150g bottle and is designed to be used on the body.The lotion contains a blend of natural ingredients such as milk protein, pearl powder, and vitamin E, which work together to nourish and hydrate the skin. Milk protein is known for its ability to moisturize and soothe dry, irritated skin, while pearl powder is believed to help brighten and even out skin tone. The lotion has a milky consistency that feels lightweight and non-greasy on the skin. It absorbs quickly without leaving a sticky residue, and leaves the skin feeling soft, smooth, and radiant. Overall, 3W Clinic Crystal White Milky Body Lotion is a good option for those looking to improve the appearance and texture of their skin, while also providing it with essential moisture and hydration.", 0, "3w clinic crystal white milky body lotion – 150gm", 0, 0, 0, 0 },
                    { new Guid("896370a4-bb45-4973-8f6b-0f628430c940"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "New Fashionable Watch for men 2023 with multiple colors", 0, 0, 0, 0 },
                    { new Guid("a1e7721a-9ae8-40cb-acb0-dfaacb54a726"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "TIAM Anti Blemish Body acne / bumpy skin / skin soothing / skin spot improvement- Special body lotion that solves skin problems- Body flaw soothing lotion: AHA, BHA, and Calamine core ingredients sooth trouble skin that is sensitive – Whitening functional ingredients clean up the bodys trouble and spots. AHA, BHA and Calamine calms down the sensitive and troubled skin. Whereas whitening ingredients helps with the dull and uneven skin tone. It also has ingredients which helps get rid of dead skin cells and sebum making skin smooth and soft. A body with a thicker skin layer than the face needs more care – Removes clogged pores and sebum with AHA, BHA, calamine and various active ingredients, and cares for skin defects to make it clean and smooth. Ingredients: Water, Niacinamide, Propanediol, Alcohol, Cetyl Ethylhex anoate, Calamine, Dimethicone, Glyceryl Stearate, PEG-100 Stearate, Polysorbate 60, Cetearyl Alcohol, Arachidyl Alcohol, Behenyl Alcohol, Arachidyl Glucoside, Sorbitan Stearate, Allantoin, Salicylic acid, Lactic Acid, Zinc PCA, (-)-alpha-bisabolol, Melaleuca Alternifolia (Tea Tree) Leaf Oil, Mentha Viridis (Spearmint) Leaf Oil, Methylpropanediol, Lauryl pyridinium Chloride, Polyacrylate-13, Polyisobutene, Polysorbate 20, Tocopheryl Acetate, PEG-60 Hydrogenated Castor Oil", 0, "TIAM ANTI BLEMISH BODY LOTION 200ML", 0, 0, 0, 0 },
                    { new Guid("b4087a37-1862-4408-a52b-2f06d122d540"), new Guid("fc7f2981-1031-4d10-8565-9cf93f211799"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour", 0, 0, 0, 0 },
                    { new Guid("c169aebd-7730-4f14-bd59-9e401bff900f"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure youre happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", 0, "SOFTSPUN Microfiber Cloth - 4 pcs - 30 x 40 cms - 340 GSM - Blue", 0, 0, 0, 0 },
                    { new Guid("c9e73593-89d9-47da-87ae-65d045c0479a"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Intel Core I7 3770 3.40 GHz Processor 4Core 8threats 8Mb Caches with turbo boost H61 Motherboard DDR III Upto 1600MHz Memory 1 x HDMI 1 x VGA 1 x PCI Express x 16 Slot 1 x PCIEX1 Slot with 10/100 Mbps LAN Onboard DDR3 8GB 1600MHz 1 TB SSD GT 730 DDR5 4GB Graphic card 22 inch Monitor VGA & HDMI has an aspect ratio of 16:9 and with 1600 x 900 pixels | GAMING Keyboard Mouse WiFi Adopter Windows 10 Pro (trail) essential software ready to play", 0, "CHIST Gaming PC Core i7 3770 processor 16 GB RAM 1 TB SSD Windows 10 GT 730 4GB ddr5 Gifted", 0, 0, 0, 0 },
                    { new Guid("cf6af44e-bca4-4a04-93ef-1af565c823d8"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "MacBook pro M2 chipset 256gb ssd 8gb ram space gray color with apple 1 year warranty", 0, 0, 0, 0 },
                    { new Guid("d1ceac0b-92e4-4bb6-9491-48e0ce701de5"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "New Fashionable Watch for men 2023 with multiple colors", 0, 0, 0, 0 },
                    { new Guid("d4448dfa-45a9-4a00-8597-ff54bc3c9ac1"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Dove Nourishing Body Care Beauty Cream 150ml", 0, 0, 0, 0 },
                    { new Guid("dd634878-1f11-4da3-b680-4576e3f73c70"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Dove Nourishing Body Care Visible Glow Self Lotion 400ml", 0, 0, 0, 0 },
                    { new Guid("e1748df2-940a-47dc-8c02-78a6d264015e"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour", 0, 0, 0, 0 },
                    { new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Display The device features a 6.43-inch FHD+ Super AMOLED display with a screen resolution of 1080 x 2400 pixels. The bezel-less punch-hole display of the mobile is protected by Corning Gorilla Glass v3 and has a refresh rate of 60Hz. The display offers a fantastic viewing experience with an aspect ratio of 20:9 and a pixel density of 409ppi. The display is bright, and vivid, and offers excellent color accuracy, making it ideal for watching videos and playing games. Camera One of the most striking features of the Oppo F17 Pro is its Quad Camera setup on the rear side. The device features a 48MP f/1.7 Primary Camera with 10x Digital Zoom and ISOCELL Plus Sensor, an 8MP f/2.2 Ultra Wide Angle Camera accompanied by dual 2MP f/2.4 Mono Cameras. The camera setup offers excellent performance, capturing stunning photos and videos in all lighting conditions. The camera setup also offers features like Night mode, AI Scene Recognition, and Ultra Steady Video 2.0, making it a great device for vloggers and photographers. The device also features a dual-camera setup on the front, featuring a 16MP f/2.4 Wide Angle Primary Camera and a 2MP f/2.4 depth-sensing camera capable of capturing detailed self-portraits. The front camera setup also offers features like AI Beautification, Bokeh Effect, and AI Night Flare Portrait, making it an excellent choice for selfie lovers. Configuration and Battery The F17 Pro performs on MediaTek Helio P95 chipset and is also powered by an Octa-Core processor set up with Cortex A75 2.2GHz Dual-Core and Cortex A55 2GHz Hexa-Core. It also features a massive 8GB RAM along with PowerVR GM9446 GPU, offering an impressive gaming experience. The device runs on Android 10 and has a 4015mAh non-replaceable Li-ion battery, equipped with 30W v4.0 VOOC Charging technology. The battery life of the device is impressive, lasting a full day on moderate usage Storage and Connectivity The internal memory offered by Oppo F17 Pro is 128GB, which can be expanded up to 256GB as per users requirements. The device supports all 4G VoLTE, Mobile Hotspot, Wi-Fi, A-GPS Glonass, USB Type-C, and Bluetooth v5.1, making it a well-connected device.", 0, "OPPO F17 ProUltra Function, Ultimate Fun", 0, 0, 0, 0 },
                    { new Guid("e6fe207e-b971-446b-9197-d663ec259b00"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Foldable headphones featuring Bluetooth® 5.1 wireless technology with full over-ear design for a better sense of isolation and greater comfort. Enjoy 25 hours of music with Deep Bass and clear calls with HQ voice calls.", 0, "Headphones Bluetooth Style 3 Lavender", 0, 0, 0, 0 },
                    { new Guid("ed04c722-75d4-4611-95fb-1e8d9d036a64"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "1 cross button function two left and right 3D joystick functions 8 numeric keys 4 function keys. With 7 channels of LED indication.The device is built with a Glass front (Gorilla Glass Victus), a glass back (Gorilla Glass), and an aluminum frame. Samsung Galaxy S21 Ultra 5G is fueled with a non-removable Li-Po 5000 mAh battery + Fast charging 25W + USB Power Delivery 3.0 + Fast Qi/PMA wireless charging 15W + Reverse wireless charging 4.5W. The smartphone features a 6.8 inches Dynamic AMOLED 2X display that has a 1440 x 3200 pixels resolution. The device comes in Phantom Black, Phantom Silver, Phantom Titanium, Phantom Navy, and Phantom Brown. The smartphone consists of a quad-camera: 108 MP (wide) + 10 MP (periscope telephoto) + 10 MP (telephoto) + 12 MP (ultrawide) while on the front there is a 40 MP (wide). The sensors include Fingerprint (under display, ultrasonic), accelerometer, gyro, proximity, compass, and barometer.", 0, "Dualshock Gaming Remote Controller Console Gamepad Joystick for Playstation", 0, 0, 0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("014bd7bc-7fb5-41b2-8fdf-1da889568414"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("07817aa0-d85e-4250-8964-0ef6a64a62ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0d4289de-a576-45d2-af10-f68fe0f47e64"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("17f1d840-1902-4903-85ae-7e69931a76b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("247875c3-7244-4f84-a233-612b53d6bff4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("24b6c01c-deb4-448a-88b4-bf73522fc9e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2854fd3f-5ffa-4444-aedc-33513495887b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("490252a0-7cae-4941-84f4-f9f8990b2486"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("57ab32d3-4cec-422e-8f00-cadcdadb09b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5de5e368-9b87-4070-9d72-2298bbfe92b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6bc499e1-596b-4ebd-af19-10766d3fada5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("72f3b8d9-45ff-4fe2-bd14-6651458aecf6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("79875154-f1ee-45ca-a90a-9a141dd6bb5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("833bb1db-1075-4b5e-a9ca-9c3991998224"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("896370a4-bb45-4973-8f6b-0f628430c940"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a1e7721a-9ae8-40cb-acb0-dfaacb54a726"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b4087a37-1862-4408-a52b-2f06d122d540"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c169aebd-7730-4f14-bd59-9e401bff900f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9e73593-89d9-47da-87ae-65d045c0479a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cf6af44e-bca4-4a04-93ef-1af565c823d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d1ceac0b-92e4-4bb6-9491-48e0ce701de5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d4448dfa-45a9-4a00-8597-ff54bc3c9ac1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dd634878-1f11-4da3-b680-4576e3f73c70"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e1748df2-940a-47dc-8c02-78a6d264015e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e6fe207e-b971-446b-9197-d663ec259b00"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ed04c722-75d4-4611-95fb-1e8d9d036a64"));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "ProductId", "Rating", "UserId" },
                values: new object[] { new Guid("2293b56b-e4d7-493c-b6cc-6359b1031322"), "comment", null, 5, new Guid("f3d2300a-c9cf-49b4-b137-aca949bf3b6a") });
        }
    }
}
