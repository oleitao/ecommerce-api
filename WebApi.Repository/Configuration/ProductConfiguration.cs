using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Entities.Models;

namespace WebApi.Repository.Configuration
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder) 
        {
            builder.HasData
            (
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "MacBook pro M2 chipset 256gb ssd 8gb ram space-gray color with apple 1 year warranty",
                    Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour",
                    Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "SOFTSPUN Microfiber Cloth - 4 pcs - 30 x 40 cms - 340 GSM - Blue",
                    Description = "SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure youre happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "LVSE Inside-Out T-Shirt",
                    Description = "SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure youre happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Cheap Price Mens Formal Shirt",
                    Description = "All Product Size: 15.5 Inch,16 Inch,16.5 Inch MOQ: 1 Set=3 Piece (1 from every size Fabrics Type=Fancy 100% cotton Color: As picture shown Main keywords: Mens Fancy Shirt wholesale",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "BRUTON Trendy Sports Shoes For Men (Blue)",
                    Description = "Trendy Shoes for Men With Great Comfortable. SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure you are happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Zenbook Pro Duo 15 OLED (UX582, 12th Gen Intel)",
                    Description = "ZenBook Pro Duo 15 OLED lets you get things done in style: calmly, efficiently, and with zero fuss. Its your powerful and elegant next-level companion for on-the-go productivity and creativity, featuring an amazing 4K OLED HDR touchscreen. It also includes the tilting ASUS ScreenPad™ Plus secondary 4K display that offers effortless ergonomics and seamless workflows. Powered by up to an Intel® Core™ i9 14-core processor and NVIDIA® GeForce RTX™ 3070Ti GPU, ZenBook Pro Duo 15 OLED brings you all the benefits of tomorrows technology, today.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "HP 15 Thin & Light Laptop (Intel i3 11th Gen/8GB RAM & 512GB SSD Storage/Win 11 Home + MS Office) X200 Wireless Mouse with 2.4 GHz Wireless connectivity and 18-Month Battery Life",
                    Description = "Product 1: Do Check Partner offer section for Exciting offers from HP Product 1: Processor: Intel Core i3-1115G4 (up to 4.1 GHz with Intel Turbo Boost Technology(2g),6 MB L3 cache, 2 cores)|Memory: 8 GB DDR4-3200 SDRAM (1 x 8 GB)| Storage: 512 GB PCIe NVMe M.2 SSD Product 1: Display & Graphics : 39.6 cm (15.6) diagonal, FHD, micro-edge anti-glare, 250 nits, 141 ppi, 45%NTSC |Graphics: Intel UHD Graphics Product 1: Operating System & Preinstalled Software: Windows 11 Home 64 Plus Single Language | Microsoft Office Home & Student 2021| McAfee LiveSafe (30 days free trial as default) |Pre-installed Alexa built-in- Your life simplified with Alexa. Just ask Alexa to check your calendar, create to-do lists, shopping lists, play music, set reminders, get latest news and control smart home. Product 2: Stay unbound, stay in control - enjoy lag-free 2.4GHz wireless connectivity on this durable mouse by HP with an 18-month long battery life. Product 2: Work at your pace by speeding up or slowing down tracking with adjustable DPI settings up to 1600 (800/1200/1600). Product 2: Work on your terms with an ambidextrous, contoured design suitable for both left and right-hand use. Product 2: Enjoy great compatibility across devices and on different operating systems - Windows 10, Windows 8, Windows 7, and MacOS 10.1 or higher.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Dove Nourishing Body Care Visible Glow Self Lotion 400ml",
                    Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Dove Nourishing Body Care Beauty Cream 150ml",
                    Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "3w clinic crystal white milky body lotion – 150gm",
                    Description = "3W Clinic Crystal White Milky Body Lotion is a skincare product that claims to brighten and moisturize the skin. It comes in a 150g bottle and is designed to be used on the body.The lotion contains a blend of natural ingredients such as milk protein, pearl powder, and vitamin E, which work together to nourish and hydrate the skin. Milk protein is known for its ability to moisturize and soothe dry, irritated skin, while pearl powder is believed to help brighten and even out skin tone. The lotion has a milky consistency that feels lightweight and non-greasy on the skin. It absorbs quickly without leaving a sticky residue, and leaves the skin feeling soft, smooth, and radiant. Overall, 3W Clinic Crystal White Milky Body Lotion is a good option for those looking to improve the appearance and texture of their skin, while also providing it with essential moisture and hydration.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Vaseline, Intensive Care, Essential Healing Body Lotion, 20.3 fl oz 600 ml",
                    Description = "We believe everyone, everywhere deserves healed skin. Thats why we created the Vaseline® Healing Project, to help people living in crisis and disaster care for their skin. Here, Vaseline® Jelly is a necessity. Our Essential Healing lotion, powered by the same extraordinary Vaseline® Jelly, deeply moisturizes to keep dry skin healed for 3 weeks.*Our unique formula includes pure oat extract and Vaseline® Jelly, without feeling greasy.Our revolutionary smart pump unlocks and locks with just a 90º turn - even in the raised position, with no mess.*Proven after 4 weeks daily use in a clinical study.Water, glycerin, stearic acid, isopropyl myristate, mineral oil, glyceryl stearate, glycol stearate, dimethicone, peg-100 stearate, petrolatum, cetyl alcohol, tapioca starch, phenoxyethanol, magnesium aluminum silicate, methylparaben, acrylates/c10-30 alkyl acrylate crosspolymer, fragrance, propylparaben, disodium EDTA, xanthan gum, stearamide amp, avena sativa (oat) straw extract, titanium dioxide (ci 77891).",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "TIAM ANTI BLEMISH BODY LOTION 200ML",
                    Description = "TIAM Anti Blemish Body acne / bumpy skin / skin soothing / skin spot improvement- Special body lotion that solves skin problems- Body flaw soothing lotion: AHA, BHA, and Calamine core ingredients sooth trouble skin that is sensitive – Whitening functional ingredients clean up the bodys trouble and spots. AHA, BHA and Calamine calms down the sensitive and troubled skin. Whereas whitening ingredients helps with the dull and uneven skin tone. It also has ingredients which helps get rid of dead skin cells and sebum making skin smooth and soft. A body with a thicker skin layer than the face needs more care – Removes clogged pores and sebum with AHA, BHA, calamine and various active ingredients, and cares for skin defects to make it clean and smooth. Ingredients: Water, Niacinamide, Propanediol, Alcohol, Cetyl Ethylhex anoate, Calamine, Dimethicone, Glyceryl Stearate, PEG-100 Stearate, Polysorbate 60, Cetearyl Alcohol, Arachidyl Alcohol, Behenyl Alcohol, Arachidyl Glucoside, Sorbitan Stearate, Allantoin, Salicylic acid, Lactic Acid, Zinc PCA, (-)-alpha-bisabolol, Melaleuca Alternifolia (Tea Tree) Leaf Oil, Mentha Viridis (Spearmint) Leaf Oil, Methylpropanediol, Lauryl pyridinium Chloride, Polyacrylate-13, Polyisobutene, Polysorbate 20, Tocopheryl Acetate, PEG-60 Hydrogenated Castor Oil",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Samsung S21 Ultra",
                    Description = "Samsung Galaxy S21 Ultra 5G is officially announced on January 14, 2021. The smartphone is pack with 12 GB and 16 GB RAM with 128 GB, 256 GB, 512 GB internal storage options. The device is built with a Glass front (Gorilla Glass Victus), a glass back (Gorilla Glass), and an aluminum frame. Samsung Galaxy S21 Ultra 5G is fueled with a non-removable Li-Po 5000 mAh battery + Fast charging 25W + USB Power Delivery 3.0 + Fast Qi/PMA wireless charging 15W + Reverse wireless charging 4.5W. The smartphone features a 6.8 inches Dynamic AMOLED 2X display that has a 1440 x 3200 pixels resolution. The device comes in Phantom Black, Phantom Silver, Phantom Titanium, Phantom Navy, and Phantom Brown. The smartphone consists of a quad-camera: 108 MP (wide) + 10 MP (periscope telephoto) + 10 MP (telephoto) + 12 MP (ultrawide) while on the front there is a 40 MP (wide). The sensors include Fingerprint (under display, ultrasonic), accelerometer, gyro, proximity, compass, and barometer.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Dualshock Gaming Remote Controller Console Gamepad Joystick for Playstation",
                    Description = "1 cross button function two left and right 3D joystick functions 8 numeric keys 4 function keys. With 7 channels of LED indication.The device is built with a Glass front (Gorilla Glass Victus), a glass back (Gorilla Glass), and an aluminum frame. Samsung Galaxy S21 Ultra 5G is fueled with a non-removable Li-Po 5000 mAh battery + Fast charging 25W + USB Power Delivery 3.0 + Fast Qi/PMA wireless charging 15W + Reverse wireless charging 4.5W. The smartphone features a 6.8 inches Dynamic AMOLED 2X display that has a 1440 x 3200 pixels resolution. The device comes in Phantom Black, Phantom Silver, Phantom Titanium, Phantom Navy, and Phantom Brown. The smartphone consists of a quad-camera: 108 MP (wide) + 10 MP (periscope telephoto) + 10 MP (telephoto) + 12 MP (ultrawide) while on the front there is a 40 MP (wide). The sensors include Fingerprint (under display, ultrasonic), accelerometer, gyro, proximity, compass, and barometer.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Headphones Bluetooth Style 3 Lavender",
                    Description = "Foldable headphones featuring Bluetooth® 5.1 wireless technology with full over-ear design for a better sense of isolation and greater comfort. Enjoy 25 hours of music with Deep Bass and clear calls with HQ voice calls.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Bluetooth Wireless Headset V5.1 Hands-free In-ear Hearphone With Microphone For Iphone Android",
                    Description = "Latest Bluetooth 5.1 Technology-This Bluetooth headset adopts Bluetooth V5.1 standard, you can achieve faster and more stable transmission. The transmission distance is up to 10m (32.8ft) (without obstacles). Compatible with most Bluetooth-enabled devices, such as iPhone, Huawei, Samsung Galaxy, LG, Sony, PC, laptop, etc. It can also be used with 2 devices can be connected at the same time, so you can separate your life and work.Long Working Time-The wireless headset has been tested for up to 10 hours of continuous calls and music time. 180 hours standby time. Fulfill your calling needs while multitasking with amazingly crisp and clear sound. The cell phone Bluetooth headset features Type-C fast charging, which can provide 7 hours of face-to-face communication experience with a single 1-hour fast charge. Clear Sound & High Quality Audio-The wireless headphones with a CVC 8.State-of-the-art noise reduction, which produces a more natural, distortion-free sound quality and clear sound. Dual microphone is designed for calls, not only is it easy to hear other people, but also prevents the noise and sounds around you from being picked up, you can enjoy high quality music and clear phone calls. Comfortable Lightweight Design-The lightweight construction makes it the perfect headset for drivers or business people,The main body of the bluetooth headset weights only 12g (0.4oz), which will not cause any pain even if worn for a long time.Moreover The earhook can rotate 270 so you can adjust it to your preferred angle. small, medium and large Three optional ear tips ensure a comfortable fit for both left and right ears.Hands-free & Mute Button- The bluetooth hands-free headset is equipped with a multi-function button, you can play or pause music, answer/end/reject calls. You can also enable voice controls like Siri and Google Assistant. In addition, you can press the separate mute button for 2 seconds to activate/deactivate the microphone, protect your privacy when you need it.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Onex 16 Bangles with Golden Stone Work for Women Casual Wear Traditional Golden Diamond Single Line Bangle Set for Girls Churi Set",
                    Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "OPPO F17 ProUltra Function, Ultimate Fun",
                    Description = "Display The device features a 6.43-inch FHD+ Super AMOLED display with a screen resolution of 1080 x 2400 pixels. The bezel-less punch-hole display of the mobile is protected by Corning Gorilla Glass v3 and has a refresh rate of 60Hz. The display offers a fantastic viewing experience with an aspect ratio of 20:9 and a pixel density of 409ppi. The display is bright, and vivid, and offers excellent color accuracy, making it ideal for watching videos and playing games. Camera One of the most striking features of the Oppo F17 Pro is its Quad Camera setup on the rear side. The device features a 48MP f/1.7 Primary Camera with 10x Digital Zoom and ISOCELL Plus Sensor, an 8MP f/2.2 Ultra Wide Angle Camera accompanied by dual 2MP f/2.4 Mono Cameras. The camera setup offers excellent performance, capturing stunning photos and videos in all lighting conditions. The camera setup also offers features like Night mode, AI Scene Recognition, and Ultra Steady Video 2.0, making it a great device for vloggers and photographers. The device also features a dual-camera setup on the front, featuring a 16MP f/2.4 Wide Angle Primary Camera and a 2MP f/2.4 depth-sensing camera capable of capturing detailed self-portraits. The front camera setup also offers features like AI Beautification, Bokeh Effect, and AI Night Flare Portrait, making it an excellent choice for selfie lovers. Configuration and Battery The F17 Pro performs on MediaTek Helio P95 chipset and is also powered by an Octa-Core processor set up with Cortex A75 2.2GHz Dual-Core and Cortex A55 2GHz Hexa-Core. It also features a massive 8GB RAM along with PowerVR GM9446 GPU, offering an impressive gaming experience. The device runs on Android 10 and has a 4015mAh non-replaceable Li-ion battery, equipped with 30W v4.0 VOOC Charging technology. The battery life of the device is impressive, lasting a full day on moderate usage Storage and Connectivity The internal memory offered by Oppo F17 Pro is 128GB, which can be expanded up to 256GB as per users requirements. The device supports all 4G VoLTE, Mobile Hotspot, Wi-Fi, A-GPS Glonass, USB Type-C, and Bluetooth v5.1, making it a well-connected device.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Lenovo Tab P10 | 10.1 Family Entertainment Tablet",
                    Description = "Immerse yourself in deep, booming sound that delivers a theater-like experience for movies, shows, and videos. Its four front speakers and Dolby Atmos® support deliver an immersive, cinematic experience.Every member of the family will have their own tailored—and secure—experience with the Tab P10. Each user gets their own account—accessible through a multi-user fingerprint reader—with individualized settings, wallpaper, and social media accounts.Since every member of the family gets their own account on the Tab P10, parents can make sure their kids stay safe. Secure the content your kids access and put time limits on their usage. The Tab P10 also boasts enhanced eye protection and easy-to-use voice search.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Kids Smart Watch,Boy Watch and Girls Watch Phone with Childrens Digital Camera Games Smart Alarm Clocks Music Player Calculator for 9 Year Olds Girls Boys As Birthday Toy Gifts or Cool Gadgets",
                    Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "MacBook pro M2 chipset 256gb ssd 8gb ram space gray color with apple 1 year warranty",
                    Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "New Fashionable Watch for men 2023 with multiple colors",
                    Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "New Trend shoes for gents with all sizes",
                    Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "New Fashionable Watch for men 2023 with multiple colors",
                    Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour",
                    Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "Gaming Headphone Asus with mutiple color and free delivery",
                    Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("693E8C88-571B-41E9-9AD1-CD21FC8FF9B4"),
                    Name = "CHIST Gaming PC Core i7 3770 processor 16 GB RAM 1 TB SSD Windows 10 GT 730 4GB ddr5 Gifted",
                    Description = "Intel Core I7 3770 3.40 GHz Processor 4Core 8threats 8Mb Caches with turbo boost H61 Motherboard DDR III Upto 1600MHz Memory 1 x HDMI 1 x VGA 1 x PCI Express x 16 Slot 1 x PCIEX1 Slot with 10/100 Mbps LAN Onboard DDR3 8GB 1600MHz 1 TB SSD GT 730 DDR5 4GB Graphic card 22 inch Monitor VGA & HDMI has an aspect ratio of 16:9 and with 1600 x 900 pixels | GAMING Keyboard Mouse WiFi Adopter Windows 10 Pro (trail) essential software ready to play",
                    Price = 0,
                    Discount_Price = 0,
                    Rating = 0,
                    Total_Sell = 0,
                    Stock = 0
                }
            );
        }    
    }
}
