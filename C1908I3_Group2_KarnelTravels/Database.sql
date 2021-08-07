create database Travel_tour
go

 use Travel_tour
 go

     create table Category_Servi
 (
	ID int identity(1,1) primary key,
	Name varchar(250),
 )

      create table Category_tour
 (
	ID int identity(1,1) primary key,
	Name varchar(250),
 )

    create table Travel
 (
	ID int identity(1,1) primary key,
	Name varchar(250),
	Img varchar(250)
 )



  create table Tourist_Spots
 (
	ID varchar(250) primary key,
	Name varchar(250),
	Addr varchar(250),
	Descrip varchar(2500),
	Active varchar(2500),
	CategoryID int constraint FK_Tourist_Spots_CategoryID_PK_Category_tour_ID references Category_tour(ID),
	Stt bit 
)


     create table Account
 (
    ID int identity(1,1)  primary key,
 	Username varchar(250),
	Pass varchar(250),
	Name varchar(250),
	Phone char(250),
	Addr varchar(250),
	Email varchar(100),
	Rol varchar(25),
	Stt bit
 )

 create table Servi
 (
	ID varchar(250) primary key,
	Name varchar(250),
	Addr varchar(250),
	Descrip varchar(2500),
	Price money,
	TourID varchar(250) constraint FK_Servi_TourID_PK_Tourist_Spots_ID references Tourist_Spots(ID),
	CategoryID int constraint FK_Servi_CategoryID_PK_Category_Servi_ID references Category_Servi(ID) ,
	Stt bit
 )

       create table Img
 (
    ID int identity(1,1) primary key,
	Name varchar(250),
	ServiID varchar(250) default null constraint FK_Img_ServiID_PK_Servi_ID references Servi(ID) ,
	TourID varchar(250) default null constraint FK_Img_TourID_PK_Tourist_Spots_ID references Tourist_Spots(ID) 
 )

create table Tour_travel 
(
	ID int identity(1,1) primary key,
	TourID varchar(250) constraint FK_Tour_travel_TourID_PK_Tourist_Spots_ID references Tourist_Spots(ID),
	TravelID int constraint FK_Tour_travel_TravelID_PK_Travel_ID references Travel(ID) ,
)

create table Servi_travel 
(
	ID int identity(1,1) primary key,
	ServiID varchar(250) constraint FK_Servi_travel_ServiID_Servi_ID references Servi(ID),
	TravelID int constraint FK_Servi_travel_TravelID_PK_Travel_ID references Travel(ID) ,
)


     create table Comment
 (
	ID int identity(1,1) primary key,
	AccID int constraint FK_Comment_AccID_PK_Account_ID references Account(ID),
	TourID varchar(250) default null constraint FK_Comment_TourID_PK_Tourist_Spots_ID references Tourist_Spots(ID) ,
	ServiID varchar(250) default null constraint FK_Comment_ServiID_Servi_ID references Servi(ID) ,
	Content varchar(250),
 )

      create table Feedback
 (
	ID int identity(1,1) primary key,
	Name varchar(50),
	Age int,
	Addr varchar(250),
	Content varchar(250),
 )

 Insert into Category_Servi(Name) Values ('Resort');
 Insert into Category_Servi(Name) Values ('Hotel');
 Insert into Category_Servi(Name) Values ('Restaurant');

 Insert into Category_tour(Name) Values ('Beach');
 Insert into Category_tour(Name) Values ('Historical sites');
  Insert into Category_tour(Name) Values ('Entertainment');

 Insert into Travel(Name,Img) Values ('Car','car.png');
 Insert into Travel(Name,Img) Values ('Train','Train.png');
 Insert into Travel(Name,Img) Values ('Planes','planes.png')
 Insert into Travel(Name,Img) Values ('Motos','moto.png');
 Insert into Travel(Name,Img) Values ('Ships','Ship.png');

 Insert into Tourist_Spots(ID,Name,Addr,Descrip,Active,CategoryID,Stt) Values ('T1','Ba Na Hill','Hoa Ninh commune, Hoa Vang district, about 25km southwest of Da Nang city center','Ba Na Hills is located in Hoa Vang district, about 25km southwest of Da Nang city center, at an altitude of 1487m above sea level. This is considered a European-class resort paradise in the heart of Da Nang city, every year, Ba Na Hills attracts millions of domestic and foreign tourists to visit.
The weather and climate here change constantly, rainy in the morning, sunny in the afternoon, foggy in the afternoon. Therefore, you need to pay attention to the weather forecast before going to have a full day of fun in Ba Na Hills!
Ba Na Hills tourism activities','
Miniature French & European Village :
.French Village is the last stop of the cable car journey, located on the top of Chua mountain. This area is designed according to ancient European architecture, like the dreamy Paris city of France, with soaring tower tops, peaceful castles.
You dont have to go to Europe when you can go to the French Village in Ba Na Hills to feel the splendor and magnificence of ancient castles, a very European beauty in the heart of Da Nang.
.Cau Vang :
	At the stop of Bordeaux Station is the Golden Bridge - the symbol of Ba Na Hills. The Golden Bridge at Ba Na Hills is one of the 100 best destinations in the world
Coming to Ba Na Hills, everyone will definitely want to check-in with this "legendary" virtual living symbol, so you should come here early in the morning, or in the afternoon to avoid the situation of having to crowded to take pictures. Please!
.Linh Ung Temple:
	The temple is located in the Ba Na Hills tourist area, which is one of the ideal places to hunt clouds in the area. Linh Ung Pagoda in Ba Na Hills together with Linh Ung Pagoda in Ngu Hanh Son Mountain and at Bai But Son Tra are located in three positions to create a three-legged stand for Da Nang.
Linh Ung Pagoda is located on a land with beautiful, sacred and poetic terrain at an altitude of 1,500m above sea level, and on the premises is a statue of Buddha Shakyamuni Buddha.
. Wine Festival :
	At the Wine Festival held in the fall, you will be directly involved in the production of wine - the famous wine of France. One of the most loved and anticipated traditional activities at European wine festivals is the La Batalla del Vino ceremony.
This ritual will be faithfully recreated at Ba Na Hills, helping you better understand the famous French drink.
.Fantasy Park:
	As the largest amusement park in Vietnam, Fantasy Park is suitable for all ages. The amusement park has more than 100 games with different levels, waiting for you to explore
	 In particular, in Fantasy Park there is an interesting place called "Back to Jurassic", which brings us back to the era of the dinosaurs, very realistic and vivid.',2,1);

Insert into Tourist_Spots(ID,Name,Addr,Descrip,Active,CategoryID,Stt) Values ('T2','Ho May',' 1A, Tran Phu, Ward 1, Vung Tau','About 100 kilometers east of Saigon, Ho May is considered the most comprehensive and famous tourist complex in the coastal city of Vung Tau. Located at an altitude of more than 210m on Big Mountain, Ho May tourist area has a mild, fresh, cool climate all year round. From here, you can see a multi-faceted Vung Tau, with the beauty of a blend of rich mountains and a bustling city.
In order to meet the diverse needs of visitors, Ho May Park is divided into many areas with separate themes. Whether you want to challenge yourself with a thrilling ride, go to a water park or visit a temple, you will have the best experience here. That is also the reason that for many years now, Ho May Park has become a favorite destination of movement associations, from solo travelers to young couples and families.
Highlights of Fun and Entertainment Activities in Ho May Tourist Area ','
.Ho May Downhill Slider - Alpine Coaster:
	Who said that you have to go to Da Lat to experience the exciting game of sledding? At Ho May Tourist Area, you can ride a sled to "chill" under the lush trees and immerse yourself in the colorful nature. Dont forget to record "cool" moments on the slide.
.Shoot paint gun:
	Paint Gun Shooting is a quality-than-distilled water idea for a large tour group of 6 to 10 people. Equipped with clothes, helmets, guns, paintballs... fully and ready to "kill and punish". Surely visitors will have a thrilling and exciting experience, no less than in games or movies.
.Cinema 5D:
	Watch 3D film? Nothing special! At Ho May Tourist Area, you will experience extremely vivid 5D movies. From sight, hearing to smell, touch, all senses seem to awaken according to each dramatic episode.
.Ho May water slide :
	Recognized as the first mountain water park in Vietnam, Ho May Park has two main water slides; they are: straight slide 30m long and curved slide 60m long. Both have a starting point at an impressive 10m and end at an artificial swimming pool.
.Visiting the Old Fort:
	Located on the slopes of Big Mountain, Old Fort is a historical and cultural relic of Vung Tau city built in 1940. When coming here, visitors seem to be living in the heroic fighting past of the Vietnamese army and people during period of resistance against French colonialism.',3,1);
Insert into Tourist_Spots(ID,Name,Addr,Descrip,Active,CategoryID,Stt) Values ('T3','Sa Pa','Sa Pa District, located in Lao Cai Province, Vietnam','The beautiful town of Sapa has a majestic natural landscape, which is likened to a convergence of earth and sky, the sapa weather is very unique with four seasons in a day. Traveling to Sapa will bring you unforgettable special experiences about the scenery and culture of indigenous peoples.','
.Sapa Market: 
	It is the trading center of the whole town of Sapa. The area that attracts the most visitors is the area selling local products such as bamboo shoots, apples, brocades and products collected on hills and mountains.
.Fansipan Peak:
	is a tourist symbol of Sapa and also a special attractive tourist destination that anyone traveling to Sapa cannot miss the opportunity to check in this sacred mountain.
.Sapa Ancient Church:
	Located in the center of Sapa is an ancient, beautiful and mysterious monastery, built by the French at the end of the 18th century, the most complete remaining architectural imprint of the French. Anyone who saw it was surprised because at that time there was a construction that was both massive and unusually elaborate.
.Ta Van version:
	Located about 8 km from Sapa town to Ta Van village, in the ripe rice season, the mountains and hills are covered with the bright yellow rice color of the whole region.',2,1)
Insert into Tourist_Spots(ID,Name,Addr,Descrip,Active,CategoryID,Stt) Values ('T4','Suoi Mo','09, Hamlet 6, Tra Co Commune, Tan Phu District, Dong Nai Province.','Suoi Mo Park is an eco-tourism area you cannot ignore when traveling to Dong Nai. Located only about 100km from the center of Saigon, this place is a place to attract young people to organize fun picnics, and also a place for families to choose to rest and enjoy the green space. every weekend.','
Activities at Dream Stream:
.Ice cream oasis:
		Leaving the heat and dust of the city, coming to the "Cream oasis" festival at Suoi Mo this year, visitors not only enjoy the summer sea air just like a miniature island but also Feel free to pose on the sea in very cool photoboots, next to the fresh air of the wild mountains and immerse yourself in the cool blue water of the cool stream.
.Sunflower garden:
	The sunflower garden is an extremely attractive "check-in" place not to be missed by many young people and tourists when visiting and relaxing this holiday season.
A quiet, unusually abundant space of the sunflower field at Suoi Mo created by the green color of life and the yellow color of hope has made everyones heart flutter indescribably.
.natural swimming pool :
	Through thousands of years of tectonics, pure underground water springs flow to form clear and cool natural lakes. Pure water is an invaluable gift that nature has bestowed on Suoi Mo, for those who love the pure beauty of nature.
.Continuous Floating House:
	This continuous floating house is a combination of many attractive and suitable games for different audiences, including an adventure game area for young people, safe and attractive games for children, and Special play area for the team

.Massage Fish:
	Fish massage is a form of relaxing foot bath in an aquarium. For the first time at Suoi Mo Park, visitors can not only immerse themselves in the beautiful natural scenery, play in the clear spring water, but also be served by "Mermaids".',3,1)
Insert into Tourist_Spots(ID,Name,Addr,Descrip,Active,CategoryID,Stt) Values ('T5','Ha Long Bay','Quang Ninh Province','Ha Long Bay is a unique heritage because this place contains important vestiges in the formation and development of earths history, is the cradle of the ancient Vietnamese people, and is also a work of art. Great shape of nature with the presence of thousands of rocky islands of all shapes and sizes, with many interesting caves gathering into a world that is both vivid and mysterious. In addition, Ha Long Bay is also home to a high concentration of biodiversity with typical ecosystems along with thousands of extremely rich and diverse species of flora and fauna. This place is also associated with the heroic historical and cultural values ​​of the nation.
vist location','
.Sun World Ha Long Park
	The leading entertainment complex in Vietnam Sun World Ha Long Park will surely bring you great relaxing moments. Right from the early days when it was completed, Sun World Ha Long Park entertainment area has become an attractive destination, attracting many tourists, especially young people. Here you can immerse yourself in thrilling and exciting games like never before in Vietnam such as: Phi Long Than Toc, Rage Rhinoceros, Pirate Ship, Dragon Footprint, ...
.Beach Fire:
	Bai Chay, located between Tuan Chau and Hon Gai islands and close to Ha Long Bay, is one of the destinations that attracts a large number of tourists to visit every time they come here. Traveling to Bai Chay, you will be immersed in the clean and cool water of the most beautiful artificial beach in Ha Long.
Thien Cung Cave:
	Located right near Dau Go Cave, Thien Cung Cave has an area of ​​​​nearly 10,000 m2, with an architecture consisting of many compartments divided into high and wide walls. When you come to Thien Cung cave, you will not be surprised by the stalactites with many unique and strange shapes. This place especially attracts international tourists to visit.
	Yen Tu Scenic Area Relic
	Yen Tu scenic area is a complex of pagodas, towers, amms, statues and surrounded by ancient forests. If traveling to Ha Long Bay in the first days of the year or at the end of the year, you can combine to Yen Tu pagoda to worship Buddha.
',2,1);

 Insert into Img(Name,TourID) Values ('T101.jpg','T1');
 Insert into Img(Name,TourID) Values ('T102.jpg','T1');
 Insert into Img(Name,TourID) Values ('T103.jpg','T1');
 Insert into Img(Name,TourID) Values ('T104.jpg','T1');
 Insert into Img(Name,TourID) Values ('T105.jpg','T1');
 Insert into Img(Name,TourID) Values ('T106.jpg','T1');
 Insert into Img(Name,TourID) Values ('T107.png','T1');
 Insert into Img(Name,TourID) Values ('T108.jpg','T1');
 Insert into Img(Name,TourID) Values ('T109.png','T1');
 Insert into Img(Name,TourID) Values ('T110.png','T1');
 Insert into Img(Name,TourID) Values ('T111.png','T1');
 Insert into Img(Name,TourID) Values ('T112.jpg','T1');
 Insert into Img(Name,TourID) Values ('T113.jpg','T1');

 Insert into Img(Name,TourID) Values ('T201.jpg','T2');
 Insert into Img(Name,TourID) Values ('T202.jpg','T2');
 Insert into Img(Name,TourID) Values ('T203.jpg','T2');
 Insert into Img(Name,TourID) Values ('T204.jpg','T2');
 Insert into Img(Name,TourID) Values ('T205.jpg','T2');
 Insert into Img(Name,TourID) Values ('T206.jpg','T2');
 Insert into Img(Name,TourID) Values ('T207.jpg','T2');
 Insert into Img(Name,TourID) Values ('T208.jpg','T2');
 Insert into Img(Name,TourID) Values ('T209.jpg','T2');
 Insert into Img(Name,TourID) Values ('T210.jpg','T2');
 Insert into Img(Name,TourID) Values ('T211.jpg','T2');
 Insert into Img(Name,TourID) Values ('T212.jpg','T2');
 Insert into Img(Name,TourID) Values ('T213.jpg','T2');

 Insert into Img(Name,TourID) Values ('T301.jpg','T3');
 Insert into Img(Name,TourID) Values ('T302.jpg','T3');
 Insert into Img(Name,TourID) Values ('T303.jpg','T3');
 Insert into Img(Name,TourID) Values ('T304.jpg','T3');
 Insert into Img(Name,TourID) Values ('T305.jpg','T3');
 Insert into Img(Name,TourID) Values ('T306.jpg','T3');
 Insert into Img(Name,TourID) Values ('T307.jpg','T3');
 Insert into Img(Name,TourID) Values ('T308.jpg','T3');
 Insert into Img(Name,TourID) Values ('T309.jpg','T3');
 Insert into Img(Name,TourID) Values ('T310.jpg','T3');
 Insert into Img(Name,TourID) Values ('T311.jpg','T3');

 Insert into Img(Name,TourID) Values ('T401.jpg','T4');
 Insert into Img(Name,TourID) Values ('T402.jpg','T4');
 Insert into Img(Name,TourID) Values ('T403.jpg','T4');
 Insert into Img(Name,TourID) Values ('T404.jpg','T4');
 Insert into Img(Name,TourID) Values ('T405.jpg','T4');
 Insert into Img(Name,TourID) Values ('T406.jpg','T4');
 Insert into Img(Name,TourID) Values ('T407.png','T4');
 Insert into Img(Name,TourID) Values ('T408.png','T4');
 Insert into Img(Name,TourID) Values ('T409.jpg','T4');
 Insert into Img(Name,TourID) Values ('T410.jpg','T4');
 Insert into Img(Name,TourID) Values ('T411.png','T4');
 Insert into Img(Name,TourID) Values ('T412.png','T4');

 Insert into Img(Name,TourID) Values ('T501.jpg','T5');
 Insert into Img(Name,TourID) Values ('T502.jpg','T5');
 Insert into Img(Name,TourID) Values ('T503.jpg','T5');
 Insert into Img(Name,TourID) Values ('T504.jpg','T5');
 Insert into Img(Name,TourID) Values ('T505.jpg','T5');
 Insert into Img(Name,TourID) Values ('T506.jpg','T5');
 Insert into Img(Name,TourID) Values ('T507.jpg','T5');
 Insert into Img(Name,TourID) Values ('T508.jpg','T5');
 Insert into Img(Name,TourID) Values ('T509.jpg','T5');
 Insert into Img(Name,TourID) Values ('T510.jpg','T5');
 Insert into Img(Name,TourID) Values ('T511.jpg','T5');



 Insert into Tour_travel(TourID,TravelID) Values ('T1',1);
 Insert into Tour_travel(TourID,TravelID) Values ('T1',2);
 Insert into Tour_travel(TourID,TravelID) Values ('T1',3);
 Insert into Tour_travel(TourID,TravelID) Values ('T1',4);
 Insert into Tour_travel(TourID,TravelID) Values ('T2',1);
 Insert into Tour_travel(TourID,TravelID) Values ('T2',2);
 Insert into Tour_travel(TourID,TravelID) Values ('T2',3);
 Insert into Tour_travel(TourID,TravelID) Values ('T3',1);
 Insert into Tour_travel(TourID,TravelID) Values ('T3',2);
  Insert into Tour_travel(TourID,TravelID) Values ('T3',3);
 Insert into Tour_travel(TourID,TravelID) Values ('T3',4);
 Insert into Tour_travel(TourID,TravelID) Values ('T4',1);
 Insert into Tour_travel(TourID,TravelID) Values ('T4',2);
  Insert into Tour_travel(TourID,TravelID) Values ('T4',3);
 Insert into Tour_travel(TourID,TravelID) Values ('T5',1);
 Insert into Tour_travel(TourID,TravelID) Values ('T5',2);
 Insert into Tour_travel(TourID,TravelID) Values ('T5',3);



 Insert into Servi(ID, Name, Addr, Descrip,Price, TourID, CategoryID,Stt) Values ('S1.1','Mercure Danang French Village','An Son Hoa Son Commune, Hoa Vang, Da Nang','Located right in the French village of Ba Na Hills tourist area, Mercure Danang French Village offers visitors a comfortable and romantic resort space in the old French style. This is the most favorite resort of tourists when coming to Ba Na Hills.
Space: The hotel has Gothic architecture, inspired by ancient villages in romantic France. Staying here, visitors seem to be lost in the French space right in Vietnam amidst the pleasant weather, unique 4 seasons in a day of Ba Na peak.
Location: Located in French village, in Ba Na Hills campus.
Scale: 470 luxury rooms with 9 room types: Standard room, Deluxe room, Superior room, Duplex Suite room, Family Suite room, Executive Suite room, Family Superior room, Bunks room and Royal Suite room.
Price for 1 night: from 1,000,000 VND/room.
Facilities: Swimming pool, Game room, Karaoke, High speed Wifi, IDD phone, TV, Minibar, heater, air conditioner, weighing scale, safe, desk, hair dryer.
phone number: +84 2363 799 888',2000,'T1',2,1);
Insert into Servi(ID, Name, Addr, Descrip, Price,TourID, CategoryID,Stt) Values ('S1.2','TRUONG CHAU HOTEL','39 Dao Duy Anh, Thac Gian, Thanh Khe, Da Nang','Budget motel in Da Nang, owns rooms with full of basic amenities so that guests staying at the hotel can feel most comfortable and relaxed.
Space:
Location: With a convenient location 1km from Da Nang center, 4km from Da Nang international airport, 2km from Cham museum, 6km from Ngu Hanh Son mountain, and 30km from Ba Na...etc.. Truong Chau is located The center of the city is very convenient to travel.
Convenient:  The rooms here are also fully equipped with basic amenities, the rooms are cleaned regularly so they are always clean and airy, near many delicious restaurants and eateries so you can discover the unique culinary features. of Da Nang....',270,'T1',2,1);
Insert into Servi(ID, Name, Addr, Descrip,Price, TourID, CategoryID,Stt) Values ('S1.3','La Crique Restaurant & Cafe Postal','Ba Na Hills tourist area, An Son Village, Hoa Ninh Commune, Hoa Vang District, Da Nang','Space: Making a difference in the design of La Crique & Café Postal design of the restaurant is the harmonious combination between the red tone of the ceiling and gray tones of the wall. The dim lights cover the old tables and chairs, creating a romantic and warm space. That space suddenly became more different by the highlight of colorful sofa sets, adding more mystery to La Crique & Cafe Postal.
Location: La Crique Restaurant & Postal Café is located in French Village, Ba Na Hills tourist area, in An Son village, Hoa Ninh commune, Hoa Vang district, Da Nang.
Cuisine: La Crique Restaurant & Café Postal specializes in Vietnamese and Asian dishes, offering hundreds of choices for diners. In particular, sandwiches, pizzas, hamburgers and Spanish dishes are prepared very carefully, meticulously and deliciously. From rustic Vietnamese dishes such as pancakes, grilled chicken to pizza, bibimbap, etc., all are prepared by professional chefs. There are also soups and cakes that are also great.
Rating: Service: 8.3, Space: 8.3, Location: 8.0, Price: 7.3, Quality 7.3, Average Score: 7.9,',100,'T1',3,1);
Insert into Servi(ID, Name, Addr, Descrip , Price, TourID, CategoryID,Stt) Values ('S1.4','Buffet restaurant La Lavande','An Son village, Hoa Ninh commune, Hoa Vang district, Da Nang city, Vietnam','Space: With a large area, Arapang restaurant has a maximum capacity of up to 4,000 guests.
Location: Behind the church of Saint Denis, in the French Village.
Price: 255k/adult, 128k/child, children under 1m are free
Cuisine: Specializing in serving diverse Asian and European cuisines, offering many attractive choices. Cold cuts, fried dishes, baked goods, hot cakes, salads, etc. are cooked deliciously and beautifully.
Rating: Service: 8, Space: 7.3, Location: 8.0, Price: 6.3, Quality 8.3, Average Score: 7.6',200,'T1',3,1);

Insert into Servi(ID, Name, Addr, Descrip, Price, TourID, CategoryID,Stt) Values ('S2.1','Cao Vung Tau Hotel','179 Thuy Van, Ward 8, Vung Tau City, Ba Ria - Vung Tau','Also known with another intimate name is Cao Hotel Vung Tau. Located on Thuy Van street and opposite the resort is the fine sand of Thuy Van beach (back beach). In this central location, it is very convenient for visitors to move to the attractive places of the city. All rooms at Cao Vung Tau have large balconies and open sea views.
Space: The hotel is designed and built modernly located right in the city center with international standards. Owning an airy view with a cool and beautiful sea view. Surely when choosing this place as a resort, you will feel satisfied with the quality of service as well as amenities.
Location: Hotel Cao Vung Tau is located at 179 Thuy Van, Ward 8 Vung Tau, Ba Ria - Vung Tau. This is the location of Vung Tau city center, close to the area of ​​Bai Thuy Van (back beach).
Scale: Cao Vung Tau Hotel has a system of 17 floors and 150 rooms, all rooms have large balconies and views overlooking Back Beach. Rooms are fully equipped with basic standard amenities. The hotel currently offers a variety of room types such as: Cozy Superior City View, Premium Ocean View, Spacious Deluxe Mountain View, Premier Executive Ocean View, Classy Suite Ocean View, Royal Family Suite Mountain.
Price: 1,000,000 VND/room
Facilities: You will be immersed in the outdoor swimming pool located on the terrace with clear blue water. Moreover, there is a separate pool area for children, a safe depth for children. Besides, the hotel also provides visitors with many facilities such as: gym, event room, conference room, car rental, tour booking, air ticket, travel service, meeting service/conference room /Event, Luggage storage area, Massage/Gym, Open 24hWifi / Free Internet / Wired Internet, Currency exchange',1000,'T2',2,1);
Insert into Servi(ID, Name, Addr, Descrip, Price, TourID, CategoryID,Stt) Values ('S2.2','Royal Villa Vung Tau','6 Tran Phu, Ward 1, Vung Tau City, Ba Ria - Vung Tau','Location: Located in Vung Tau city, Only 2.1 km from Back Beach. The property is 2.3 km from Bach Dinh and 4.1 km from Ho May Ecotourism Area. The nearest airport is Tan Son Nhat International Airport, 111 km away.
Price: from 1,000,000 VND/room
Scale: The villa has 5 bedrooms, a flat-screen TV with cable channels, an equipped kitchen with a microwave and a fridge, a washing machine, and 2 bathrooms with a shower.
Facilities: Free Wifi throughout the hotel. Housekeeping service. Outdoor swimming pool. BBQ facilities. Free parking.',1000,'T2',2,1);
Insert into Servi(ID, Name, Addr, Descrip , Price, TourID, CategoryID,Stt) Values ('S2.3','Hon Ru Ri Restaurant Vung Tau','1 Tran Phu, Ward 1, Vung Tau City, Ba Ria - Vung Tau','Space: Hon Ru Ri is divided into 2 areas. Fresh seafood restaurant area and Coffee/Breakfast area.
Location: Located at 1A, Tran Phu Street, right in front of Front Beach.
Price: 100,000 - 300,000 VND/room
Cuisine: The fresh seafood restaurant area will be designed into a bridge extending to the sea. At night, the lights are shimmering very beautiful and fanciful. This area is where visitors can enjoy countless seafood. Vung Tau is fresh and delicious. Here, visitors will directly board the raft and choose seafood, then the chef will process it into dishes according to your requirements. There are many kinds of fresh and new seafood for you to choose from such as: white pomfret, grouper, sea eel, black tiger shrimp, shrimp jam, ..
The coffee/breakfast area is built inside the mainland with a panoramic sea view. Sitting at any position at Hon Ru Ri coffee, you can see the immense and poetic Vung Tau sea.
Rating: Service: 9, Space: 8.3, Location: 8.0, Price: 7.8, Quality 8.3, Average Score: 8.1',100,'T2',3,1);
Insert into Servi(ID, Name, Addr, Descrip, Price, TourID, CategoryID,Stt) Values ('S2.4','Gio Bien Resort',' 6 Thuy Van, Thang Tam Ward, Vung Tau City, Ba Ria - Vung Tau','Gio Bien Resort with 2-star standard, has a convenient location for you to move to nearby attractions such as Back Beach, Statue of Christ, Lighthouse, Neighborhood Market... The nearest airport is the courtyard. Tan Son Nhat International Airport, 100km away.
Space: Design in modern style.
Location: Located at Thuy Van street
Scale: The resort has a total of 58 comfortable hotel rooms and 38 tube houses. Modern amenities such as flat screen television, additional bathroom, additional toilet, linens, mirror are also available in some of the rooms. Couples especially love this Resort.
Price: from 700,000 to 2,500,000 VND/room
Facilities: Free Wifi throughout the hotel. Laundry Service. Currency exchange service. 24/7 reception.',700,'T2',1,1);


 Insert into Servi(ID, Name, Addr, Descrip,Price, TourID, CategoryID,Stt) Values ('S3.1','HOTEL DE LA COUPOLE','1, Hoang Lien Street Sapa District Lao Cai Province 33000 SA0PA, VIETNAM',' Room from : 2360046₫
Space: Inspired by ethnic minorities in Sapa and French Haute Couture fashion.
Facilities: With 249 luxury rooms, all rooms here have a balcony, air conditioning, flat-screen satellite TV, kettle, jacuzzi, free toiletries, wardrobe. robe, private bathroom and seating area. Some rooms have garden views. With top-notch restaurants and bars, spa services, resorts and events, the hotel is an ideal destination for family vacations, romantic couples or successful events.
The hotel serves a buffet or continental breakfast. The on-site French restaurant Chic is open all day and serves local Vietnamese dishes. Guests can enjoy handcrafted Marou cakes and chocolates at the Cacao bakery or champagne, tapas and handcrafted cocktails at Absinthe.
Guests can ask the front desk staff for how to get around and activities in the area. The funicular station that takes guests to Fansipan cable car is right outside the property.
Location: Located in Sa Pa, Hotel de la Coupole - MGallery features an indoor heated swimming pool, spa and fitness centre.
The hotel is 600 meters from Sa Pa bus station, less than 1 km from Sa Pa Lake, a 4-minute walk from Sa Pa Central Square, 400 meters from Sa Pa Stone Church and 14 km from Fansipan Mountain.
Phone number: (+84)2143629999
Fax: (+84)2143709999
Email: ha5v2-re@accor.com',300,'T3',2,1);
Insert into Servi(ID, Name, Addr, Descrip,Price, TourID, CategoryID,Stt) Values ('S3.2','Sapa Garden Resort','52B Thac Bac Road , Sapa town , Lao Cai','The unique, new and unique eco-resort with garden house and Sapa identity with the very poetic and charming natural landscape in Sapa. Blending under the shade of green trees is a house on stilts or small wooden villas.
Space: With an area of ​​more than 8,000 m2, with many kinds of rare and precious flowers: Apples, Pears, Plums, Peach Blossoms, Do Quyen Flowers, Sapa Pines, Hoang Ba Trees and more than 100 species of flowers that are always blooming around. year in the garden
Sapa Garden with a system of rooms and restaurants serving European - Asian guests. Including Central Stilt House, Wooden Villa, Garden Cafe, Red Dao Tobacco Bath, Campfire Area, Teambuilding Area, Fish Pond, Flower Garden, Vegetable Planting Area, Pine Hill Area...
Facilities: The stilt house is located in the center of the tourist area, the dormitory area is located on the 2nd floor with an area of ​​more than 100 m2, meeting a maximum of 40 guests. In the house, there are 3 separate bedrooms, each with 1 bed of 1m6. There is a balcony to relax - there is a toilet area and 4 separate bathrooms with full amenities, hot and cold water and a hair dryer - The bedroom has sun blinds, wooden floors, glass doors and a direct view. to Ham Rong mountain and the entire garden of the Resort.
The system of rooms with pure Vietnamese architecture using mainly wood materials is very friendly to the environment and together with luxurious facilities and equipment, cozy in winter, cool in summer. mingled with the clouds like a fairyland.
Staff are trained in tourism , friendly to visitors will make you most satisfied when staying here .
LOCATION: Sapa Garden Resort is located at 52B Thac Bac street in the center of Sapa town right opposite the 5-star Silkpath Sapa hotel, Distance from Resort to Stone Church and Central Square 800 meters, to Sapa Lake and Market Sapa is 2 km , to Fansipan cable car station 3.9 km , 1 km to Ham Rong Mountain , 11 km to Silver Waterfall , 3 km to Cat Cat village , 9 km to Ta Van village , 12 km to Ta Phin village .
HOTLINE: 086.8888.588 - 09898.99099 - 024.66853888',627,'T3',1,1);
Insert into Servi(ID, Name, Addr, Descrip, Price, TourID, CategoryID,Stt) Values ('S3.3','Sapa Sky View Restaurant And Bar','Sapa Office: No.24 Dong Loi, Sapa, Lao Cai, Vietnam','Designed with a sophisticated style, bearing the characteristics of indigenous peoples, a harmonious combination of natural scenery and unique architecture, the dedication of professional staff always brings giving visitors a feeling of closeness, comfort, special impression for diners right from the first steps in the door. The restaurant serves local rustic dishes and Sapa specialties.
Space: The investor has cleverly selected local materials to make the restaurant unique and luxurious. The delicate and harmonious combination of deep colors from ancient wood of the HMong people with colorful brocade motifs always gives diners a cozy, close space with a sense of relaxation. This space is always attractive and fascinates diners, spending a lot of time on sightseeing, taking photos, checking in as well as wandering to enjoy the majestic scenery of Hoang Lien Son range. With a vast view embracing the Fansifan mountain range, diners will have the opportunity to admire the sunset, sunrise, floating clouds with the typical beauty of Sapa. Its great to enjoy a cup of hot coffee in the middle of nature, mountains and clouds, in the middle of the four-season rose garden. Perhaps for that reason, the restaurant is always loved by diners when organizing important important events such as meetings, birthdays, etc.
Cuisine: Coming to Sapa Sky View restaurant, diners will always be overwhelmed by the rich and varied menu with local specialties, the nose-splitting taste of the morning bowl of beef noodle soup, the rich sweetness of the dish. Sapa salmon salad or the mild aroma of honey roasted chicken, the greasy taste of grilled salmon with cheese. In addition, the restaurant also has many attractive options such as roasted pork, thang co, sapa spring rolls, chicken stew with mushrooms. These are the unique dishes of the restaurant that are prepared from the skillful and talented hands of chef Sapa.
Contact: 0813 241 768
091 285 78 78',1232,'T3',3,1);


Insert into Servi(ID, Name, Addr, Descrip,Price,  TourID, CategoryID,Stt) Values ('S4.1','Nhu Y Hotel','126 Hamlet 1, X Tra Co Tan Phu Dong Nai Vietnam','Ambience: Hotel Nhu Y Bien Hoa offers accommodation with a bar, free private parking, a garden and a terrace. The property offers a 24-hour front desk, room service and luggage storage for guests.
Location: 607 Huynh Van Nghe, Buu Long Ward, Bien Hoa, Dong Nai, Bien Hoa, Vietnam
Price: 700,000-1,000,000 VND/room
Scale:
Facilities: All hotel rooms are equipped with air conditioning, flat-screen satellite TV, refrigerator, kettle, shower, hairdryer and work desk. Each room also has a wardrobe and a private bathroom.',700,'T4',2,1);
Insert into Servi(ID, Name, Addr, Descrip,Price, TourID, CategoryID,Stt) Values ('S4.2','Nieu Viet Restaurant','182 Hamlet 6, Tra Co, Tan Phu, Dong Nai','Location: located at address 182-183, hamlet 6, Tra Co commune, Tan Phu district (Dong Nai). Price: 250,000 - 500,000 VND/room.
Cuisine: It is not too difficult to locate the location of this culinary space because the restaurant has a specialty of rice pot. Rating: 4 stars',300,'T4',3,1);
Insert into Servi(ID, Name, Addr, Descrip,Price, TourID, CategoryID,Stt) Values ('S4.3','Suoi Mo Park Resort',' 9 Tra Co, Tan Phu, Dong Nai','location: Located in the area of ​​Nam Cat Tien National Forest, Nam Cat Tien, is a famous choice for tourists.
Only 24.8 km from the city center,
The hotels beautiful location ensures that guests can visit tourist attractions quickly and easily.
Scale: Price: from 100,000 to 500,000 VND/room.
Facilities: The impeccable service and state-of-the-art facilities make for an unforgettable stay. A selection of top-class facilities such as 24-hour room service, facilities for disabled guests, luggage storage, Wi-Fi in public areas, car park can be enjoyed at the hotel. has a different characteristic comfort. Many rooms even provide television LCD/plasma screen, internet access – wireless (complimentary), non smoking rooms, air conditioning, wake-up service to please the most discerning guest. The hotel offers wonderful recreational facilities such as pool outdoor, kids club, garden, water sports (non-motorized) to make your stay truly unforgettable. Discover the blend of professional service and state-of-the-art amenities at Suoi Mo Park Resort.',150,'T4',1,1);


Insert into Servi(ID, Name, Addr, Descrip,Price, TourID, CategoryID,Stt) Values ('S5.1','Royal Lotus Ha Long Resort & Villas','SHENZHEN 2, HUNG THANG URBAN AREA, HUNG THANG Ward, City. HA LONG, QUANG NINH PROVINCE','Inspired by the global green living trend, it is a harmonious combination between modern living space and beautiful nature.
Space: Perfect Resort Space
All 430 rooms and 86 villas at Royal Lotus Halong Resort & Villas have luxurious design inspired by beautiful nature and modern furniture.
Facilities: ENTERTAINMENT & RELAX.Swimming Pool, Royal Spa, Outdoor Activities,Manna Beach,Enjoy Vi Vu with Royal Lotus Deals
Location: Located in Halong Marina Urban Area, Royal Lotus Halong Resort & Villas owns a prime location in the center of Ha Long city and near famous tourist attractions such as Little Vietnam, Halong Trade Center. Marine Plaza, Tuan Chau Entertainment Complex, Sunworld Ha Long Park...
HOTLINE: (84 - 203) 3593 999
EMAIL: rsvn@royallotushalongresort.com',1000,'T5',1,1);
Insert into Servi(ID, Name, Addr, Descrip,Price, TourID, CategoryID,Stt) Values ('S5.2',' Muong Thanh Grand Ha Long Hotel','No. 7, Lot 20, Dong Hung Thang, Ha Long, Quang Ninh','Enjoy the panoramic view of Ha Long water from the 4-star standard hotel Muong Thanh Grand Ha Long, you will have great and interesting experiences.
Space: at Muong Thanh Grand Ha Long Hotel, where excellent quality and attentive service are available. From here, guests can easily access the lively beauty of the city from every angle. An equally special point is the hotels easy access to countless interesting sites such as Tourist Wharf, Bai Chay, Tuan Chau Island. The hotel is only 4.5 km from Tuan Chau Island and 4.8 km from Bai Chay Bridge, very convenient for you to visit the scenic spots of Quang land.
Facilities: The special hotel has 180 beautiful rooms, equipped with air conditioning, desk, snack bar, balcony. The hotels recreational facilities, which include hot tub, steam room, outdoor pool, massage, garden are designed to give you the comfort and relaxation you need.
Services:Fitness Center Satisfy your fitness training preferences.
Swimming pool Swimming pool Modern swimming pool with open space, serving light snacks and...Raja Spa & Massage Raja Spa & Massage Soothe your body and nourish your spirit with healthy...
Contact:(+84) 203 3812 468',1000,'T5',2,1);
Insert into Servi(ID, Name, Addr, Descrip, Price, TourID, CategoryID,Stt) Values ('S5.3','Ngoc Luc Bao Restaurant','26 Ha Long, Bai Chay, Ha Long City, Quang Ninh','For gourmets of seafood or Ha Long cuisine, Ngoc Luc Bao is not a strange name. After a period of research and learning, Ngoc Luc Bao restaurant offers diners sea crab dishes combined with more than ten types of sauces made from more than 100 spices around the world. And go next to a name as close as family, as professional as 5 stars: Emerald Jewel
Location: located by Cua Luc - Ha Long Bay, We are proud to bring diners the standard of the best restaurant and are committed to becoming the restaurant with the best service with the philosophy: Bringing customers the best service. The freshest Seafood dishes, especially the Crab dish - Million Son Nhu Mot, with Asian flavor.
Space: there are many spaces for diners to choose from. Dining room in the wine cellar is negative 3 m above sea level, dining room overlooking the Gulf with Royal style, top view space for family and friends watching the marina, Bai Chay bridge. Let Ngoc Luc Bao - Crab Ngon and diners experience the most quintessential specialties on the beautiful Ha Long Bay.
Contact: 0969159888',300,'T5',3,1);

  Insert into Servi_travel (ServiID,TravelID) Values ('S1.1',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S1.1',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S1.2',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S1.2',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S1.3',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S1.3',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S1.4',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S1.4',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S1.4',5);
  Insert into Servi_travel (ServiID,TravelID) Values ('S2.1',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S2.1',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S2.2',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S2.2',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S2.3',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S2.3',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S2.4',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S2.4',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S2.4',5);
    Insert into Servi_travel (ServiID,TravelID) Values ('S3.1',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S3.1',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S3.2',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S3.2',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S3.3',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S3.3',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S4.1',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S4.1',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S4.1',5);
  Insert into Servi_travel (ServiID,TravelID) Values ('S4.2',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S4.2',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S4.3',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S4.3',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S5.1',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S5.1',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S5.1',5);
    Insert into Servi_travel (ServiID,TravelID) Values ('S5.2',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S5.2',4);
  Insert into Servi_travel (ServiID,TravelID) Values ('S5.3',1);
  Insert into Servi_travel (ServiID,TravelID) Values ('S5.3',4);



Insert into Img (Name, ServiID) values ('S101.1.jpg','S1.1');
Insert into Img (Name, ServiID) values ('S101.2.jpg','S1.1');
Insert into Img (Name, ServiID) values ('S102.1.jpg','S1.2');
Insert into Img (Name, ServiID) values ('S102.2.jpg','S1.2');
Insert into Img (Name, ServiID) values ('S103.1.jpg','S1.3');
Insert into Img (Name, ServiID) values ('S103.2.jpg','S1.3');
Insert into Img (Name, ServiID) values ('S104.1.PNG','S1.4');
Insert into Img (Name, ServiID) values ('S104.2.jpg','S1.4');
Insert into Img (Name, ServiID) values ('S201.1.jpg','S2.1');
Insert into Img (Name, ServiID) values ('S201.2.jpg','S2.1');
Insert into Img (Name, ServiID) values ('S202.1.jpg','S2.2');
Insert into Img (Name, ServiID) values ('S202.2.jpg','S2.2');
Insert into Img (Name, ServiID) values ('S203.1.jpg','S2.3');
Insert into Img (Name, ServiID) values ('S203.2.jpg','S2.3');
Insert into Img (Name, ServiID) values ('S204.1.jpg','S2.4');
Insert into Img (Name, ServiID) values ('S204.2.jpg','S2.4');
Insert into Img (Name, ServiID) values ('S301.1.jpg','S3.1');
Insert into Img (Name, ServiID) values ('S301.2.jpg','S3.1');
Insert into Img (Name, ServiID) values ('S302.1.jpg','S3.2');
Insert into Img (Name, ServiID) values ('S302.2.jpg','S3.2');
Insert into Img (Name, ServiID) values ('S303.1.jpg','S3.3');
Insert into Img (Name, ServiID) values ('S303.2.jpg','S3.3');
Insert into Img (Name, ServiID) values ('S401.1.jpg','S4.1');
Insert into Img (Name, ServiID) values ('S401.2.jpg','S4.1');
Insert into Img (Name, ServiID) values ('S402.1.jpg','S4.2');
Insert into Img (Name, ServiID) values ('S402.2.jpg','S4.2');
Insert into Img (Name, ServiID) values ('S403.1.jpg','S4.3');
Insert into Img (Name, ServiID) values ('S403.2.jpg','S4.3');
Insert into Img (Name, ServiID) values ('S501.1.jpg','S5.1');
Insert into Img (Name, ServiID) values ('S501.2.jpg','S5.1');
Insert into Img (Name, ServiID) values ('S502.1.jpg','S5.2');
Insert into Img (Name, ServiID) values ('S502.2.jpg','S5.2');
Insert into Img (Name, ServiID) values ('S503.1.jpg','S5.3');
Insert into Img (Name, ServiID) values ('S503.2.jpg','S5.3');


