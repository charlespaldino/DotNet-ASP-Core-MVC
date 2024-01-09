SET IDENTITY_INSERT [dbo].[MonthlySpecials] ON
INSERT INTO [dbo].[MonthlySpecials] ([ID], [Tags], [Name], [Description], [ImageURL], [URL], [Type], [Price]) VALUES (1, N'Spa', N'Day Spa Package', N'California Calm', N'/images/calm_bug.gif', N'/tours/tour_detail_cycle.htm', 0, CAST(250.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[MonthlySpecials] ([ID], [Tags], [Name], [Description], [ImageURL], [URL], [Type], [Price]) VALUES (2, N'Travel, Sea, Ocean, Beach', N'2 Day Salton Sea', N'From Desert to Sea', N'/images/desert_bug.gif', N'/tours/tour_detail_cycle.htm', 1, CAST(350.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[MonthlySpecials] ([ID], [Tags], [Name], [Description], [ImageURL], [URL], [Type], [Price]) VALUES (3, N'Backpacking', N'Big Sur Retreat', N'Backpack Cali', N'/images/backpack_bug.gif', N'/tours/tour_detail_cycle.htm', 2, CAST(620.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[MonthlySpecials] ([ID], [Tags], [Name], [Description], [ImageURL], [URL], [Type], [Price]) VALUES (4, N'Food', N'Tapas & Groves', N'Taste of California', N'/images/taste_bug.gif', N'/tours/tour_detail_taste.htm', 3, CAST(150.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[MonthlySpecials] OFF

SET IDENTITY_INSERT [dbo].[TriviaFacts] ON
INSERT INTO [dbo].[TriviaFacts] ([ID], [Details]) VALUES (1, N'California produces over 17 million gallons of wine each year!')
INSERT INTO [dbo].[TriviaFacts] ([ID], [Details]) VALUES (2, N'California is home to the highest and lowest points in the continental U.S.')
INSERT INTO [dbo].[TriviaFacts] ([ID], [Details]) VALUES (3, N'More movies have been filmed in California than in any other state in the U.S.')
INSERT INTO [dbo].[TriviaFacts] ([ID], [Details]) VALUES (4, N'In 1964, San Francisco’s cable cars were named the first moving National Historic Landmark.')
INSERT INTO [dbo].[TriviaFacts] ([ID], [Details]) VALUES (5, N'San Francisco has its own poop map.')
INSERT INTO [dbo].[TriviaFacts] ([ID], [Details]) VALUES (6, N'California has one of the highest rates of homelessness.')
INSERT INTO [dbo].[TriviaFacts] ([ID], [Details]) VALUES (7, N'Shoplifting under $950 is misdemeanor.')
INSERT INTO [dbo].[TriviaFacts] ([ID], [Details]) VALUES (8, N'Someone''s closet under the stairs rents for $500 a month.')
SET IDENTITY_INSERT [dbo].[TriviaFacts] OFF


SET IDENTITY_INSERT [dbo].[Tours] ON
INSERT INTO [dbo].[Tours] ([ID], [Name], [ImageURL], [Description], [SplashPosterURL], [SplashHTML]) VALUES (1, N'Backpack Cal', N'/images/back_bug.gif', N'Explore California our favorite way...by foot! Get outdoors and into the millions of acres of forests, desert, and spectacular scenery that California is famous for. We have a wide range of backpacking tour options, from single day-trips to week long guided excursions. Find a comfortable pair of shoes and come hiking with us!', N'/images/backpack_main.jpg', N'<div class="multiCol"><p>Want a chance to get away from it all? Do you prefer to see nature at your own pace? Respond to the call of the great outdoors with our Backpack Cal tour packages. Whether it''s hiking beneath the towering Redwoods, walking the ridges of the beautiful Channel Islands, or testing yourself against the harshest environments nature has to offer, we have a tour for your abilities and interests. </p>
    <p>If you''re looking to just take in the incredible natural beauty of California at your own pace, try our Big Sur Retreat, a stress-free retreat into one of America''s most beautiful forest regions. If you have the spirit of an adventurer and are looking for a challenge, try our Death Valley Survivor''s Trek, an aptly-named tour that will test your endurance and mental strength as you pit yourself against the harshest desert conditions in the country. </p>
    <p>Our Backpack Cal Tours offer a range of physical activity, from easy to difficult. Please check the difficulty rating before booking a tour to ensure that your experience is the best possible for your current fitness level. Tours with a rating of Moderate or higher require a signed waiver before booking.</p>
</div>')
INSERT INTO [dbo].[Tours] ([ID], [Name], [ImageURL], [Description], [SplashPosterURL], [SplashHTML]) VALUES (2, N'California Calm', N'/images/calm_desc_bug.gif', N'Looking for a little relaxation? California Calm is our hand-picked collection of incredible California Spas and therapy retreats. Enjoy unbelievable massage treatments, beauty regimens, and active getaways. We''ve combed the entire state to find the finest spa experiences available...imagine that, we''ve even made choosing a spa retreat relaxing!', N'', N'')
INSERT INTO [dbo].[Tours] ([ID], [Name], [ImageURL], [Description], [SplashPosterURL], [SplashHTML]) VALUES (3, N'California Hotsprings', N'/images/springs_desc_bug.gif', N'Let''s be honest, you have no idea what a hot spring is...do you? Well, we do, and we can''t wait for you to experience the relaxing warmth of "nature''s hot-tubs!" We offer packages that range from all-inclusive hot spring resorts to camping opportunities next to some of the country''s last remaining primitive springs.', N'', N'')
INSERT INTO [dbo].[Tours] ([ID], [Name], [ImageURL], [Description], [SplashPosterURL], [SplashHTML]) VALUES (4, N'Cycle California', N'/images/cycle_desc_bug.gif', N'Whether you are a hard-core mountain biking enthusiast, or just looking for a cool way to see the many scenic towns and vistas of our great state, Cycle California has a package for you! Explore the thousand of miles of biking trails from Big Sur all the way to the Southern California coast. Packages range from bring-your-own bike to full bike rental and travel days.learn more!', N'', N'')
INSERT INTO [dbo].[Tours] ([ID], [Name], [ImageURL], [Description], [SplashPosterURL], [SplashHTML]) VALUES (6, N'From Desert to Sea', N'/images/desert_desc_bug.gif', N'Our most wide-ranging tour option! Come explore California from the stunning deserts all the way to our beautiful coast. Along the way you''ll travel through breathtaking mountain ranges and some of the nation''s most fertile farmland as you see why California is regarded as the most diverse state in the nation! Come see ALL that California has to offer!', N'', N'')
INSERT INTO [dbo].[Tours] ([ID], [Name], [ImageURL], [Description], [SplashPosterURL], [SplashHTML]) VALUES (7, N'Kids California', N'/images/kids_desc_bug.gif', N'Over and over again our customer support people would hear, "but what if we have kids?" when describing a tour. Then it hit us...why not create tours specifically for kids?! California is an amazing playground for everyone and should be experienced by all. From amazing museums, outstanding parks, Disney, and kid-centered nature experiences, Kids California truly has it all!', N'', N'')
INSERT INTO [dbo].[Tours] ([ID], [Name], [ImageURL], [Description], [SplashPosterURL], [SplashHTML]) VALUES (8, N'Nature Watch', N'/images/nature_desc_bug.gif', N'If you love the outdoors, nature, and the environment, California is the place for you! Our eco-tours range from watching seals and whales to exploring the desert for rare lizards and fauna. As inspirational as they are educational, our Nature Watch packages bring you the full range of California''s natural beauty.', N'', N'')
INSERT INTO [dbo].[Tours] ([ID], [Name], [ImageURL], [Description], [SplashPosterURL], [SplashHTML]) VALUES (9, N'Snowboard Cali', N'/images/snow_desc_bug.gif', N'California has some of the best snowboarding in the US and at Explore California we''ve combed the runs to offer you the best resorts in the state. We even offer multi-resort packages for those that just can''t get enough of that pack and grind. See you on the slopes!', N'', N'')
INSERT INTO [dbo].[Tours] ([ID], [Name], [ImageURL], [Description], [SplashPosterURL], [SplashHTML]) VALUES (10, N'Taste of California', N'/images/taste_desc_bug.gif', N'Tour of the wine country? Tour of the olive groves? We couldn''t decide so we put them together in one of our most amazing tour packages ever. Taste of California immerses you in the serene, romantic lifestyle of the California wine country and olive groves. Along the way you''ll experience some of the best cuisine in the world, all made from fresh local ingredients by some of the nation''s most renown chefs. Bon Appetit!', N'', N'')
SET IDENTITY_INSERT [dbo].[Tours] OFF



SET IDENTITY_INSERT [dbo].[TourDetail] ON
INSERT INTO [dbo].[TourDetail] ([ID], [TourID], [Name], [ImageURL], [Description], [Rating], [DurationDays], [Price], [Options]) VALUES (1, 1, N'Big Sur Retreat', N'/images/map_bigsur.gif', N'Big Sur is big country. The Big Sur Retreat takes you to the most majestic part of the Pacific Coast and show you secret trails and spectacular scenery. This is one of our most flexible tours, with enough options to satisfy the casual hiker to the hard core experience junkie.', 1, 3, CAST(750.00 AS Decimal(18, 2)), N'Optional 4 day tour available')
INSERT INTO [dbo].[TourDetail] ([ID], [TourID], [Name], [ImageURL], [Description], [Rating], [DurationDays], [Price], [Options]) VALUES (2, 1, N'Channel Islands Excursion', N'/images/map_channel.gif', N'The chain known as the Channel Islands offer some of the most diverse and unique landscape on the Pacific coast. No motor vehicles are allowed on the islands, which makes this relaxing day trip hiking package the best and most interesting way to visit.', 0, 1, CAST(150.00 AS Decimal(18, 2)), N'')
INSERT INTO [dbo].[TourDetail] ([ID], [TourID], [Name], [ImageURL], [Description], [Rating], [DurationDays], [Price], [Options]) VALUES (3, 1, N'The Death Valley Survivor''s Trek', N'/images/map_valley.gif', N'Hot stuff? Need more of a challenge? Take this tour to the hottest place in North America: Death Valley. Due to extreme temperatures (120 degrees and higher) in the summer months, this tour is only offered November through April. Are you up to the challenge?', 2, 2, CAST(250.00 AS Decimal(18, 2)), N'')
INSERT INTO [dbo].[TourDetail] ([ID], [TourID], [Name], [ImageURL], [Description], [Rating], [DurationDays], [Price], [Options]) VALUES (4, 1, N'In the Steps of John Muir', N'/images/map_yosemite.gif', N'Follow in the steps on John Muir, famous naturalist and founder of the Sierra Club, and walk the same trails he helped blaze in and around Yosemite National Park.', 2, 3, CAST(600.00 AS Decimal(18, 2)), N'')
INSERT INTO [dbo].[TourDetail] ([ID], [TourID], [Name], [ImageURL], [Description], [Rating], [DurationDays], [Price], [Options]) VALUES (5, 1, N'The Mt. Whitney Climbers Tour
', N'/images/map_whitney.gif', N'Climb to the sky! The Mt. Whitney Climbers Tour takes you to the top of this 14,000 ft. of mountain in 4 days- our longest and most strenuous backpacking tour. Explore California will set you up with a trail permit, a two night camping pass, and an expert guide.', 2, 4, CAST(650.00 AS Decimal(18, 2)), NULL)
SET IDENTITY_INSERT [dbo].[TourDetail] OFF

SET IDENTITY_INSERT [dbo].[TourInfo] ON
INSERT INTO [dbo].[TourInfo] ([ID], [TourDetailID], [Name], [SplashPosterURL], [SplashHTML], [ParentName]) VALUES (1, 1, N'Big Sur Retreat', N'/images/big_sur.jpg', N' <p>The region know as Big Sur is like Yosemite''s younger cousin, with all the redwood scaling, rock climbing and, best of all, hiking that the larger park has to offer. Robison Jeffer''s once said, &quot;Big Sur is the greatest meeting of land and sea in the world,&quot; but the highlights are only accessible on foot.</p>
 <p>Our 3-day tour allows you to choose from multiple hikes led by experienced guides during the day, while comfortably situated in the evenings at the historic Big Sur River Inn. Take a tranquil walk to the coastal waterfall at Julia Pfeiffer Burns State Par or hike to the Married Redwoods. If you''re prepared for a more strenuous climb, try Ollason''s Peak in Toro Park. An optional 4th day includes admission to the Henry Miller Library and the Point Reyes Lighthouse.</p>
 <p>View <a href="tour_detail_bigsur_trails.htm">hiking trail information</a> to help you plan which trail is right for you.</p>
 <h2>Tour Highlights</h2>
 <ul>
   <li>Stay at the historic Big Sur River Inn</li>
   <li>Privately guided hikes </li>
   <li>Hike through any of the 5 surrounding national parks</li>
   <li>Picnic lunches prepared by the River Inn kitchen</li>
   <li>Complimentary country breakfast</li>
   <li>Optional 4th day includes:<ul>
       <li>Admission to the Henry Miller Library</li>
       <li>Tour the Point Reyes Lighthouse</li>
     </ul>
   </li>
   <li>Hikes available for all skill levels</li>
 </ul>', N'Backpack Cali')
SET IDENTITY_INSERT [dbo].[TourInfo] OFF
