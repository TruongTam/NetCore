USE [CosmecticShop]
GO
SET IDENTITY_INSERT [dbo].[CartStatuses] ON 

INSERT [dbo].[CartStatuses] ([Id], [Status]) VALUES (1, N'free')
INSERT [dbo].[CartStatuses] ([Id], [Status]) VALUES (2, N'using')
SET IDENTITY_INSERT [dbo].[CartStatuses] OFF
SET IDENTITY_INSERT [dbo].[AnoCarts] ON 

INSERT [dbo].[AnoCarts] ([Id], [CartStatus_Id], [TotalPrice], [TotalQuantity], [DateCreate], [DateModify]) VALUES (1, 2, 53100, 1, CAST(N'2019-12-09 21:04:43.8339338' AS DateTime2), CAST(N'2019-12-09 21:04:43.8340927' AS DateTime2))
INSERT [dbo].[AnoCarts] ([Id], [CartStatus_Id], [TotalPrice], [TotalQuantity], [DateCreate], [DateModify]) VALUES (2, 2, 0, 0, CAST(N'2019-12-09 22:02:02.1863584' AS DateTime2), CAST(N'2019-12-09 22:02:02.1873673' AS DateTime2))
INSERT [dbo].[AnoCarts] ([Id], [CartStatus_Id], [TotalPrice], [TotalQuantity], [DateCreate], [DateModify]) VALUES (3, 2, 611100, 2, CAST(N'2019-12-09 22:14:56.9848348' AS DateTime2), CAST(N'2019-12-09 22:14:56.9861047' AS DateTime2))
SET IDENTITY_INSERT [dbo].[AnoCarts] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Name]) VALUES (2, N'Admin')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (3, N'Author')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (1, N'SuperAdmin')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (4, N'User')
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Role_Id], [Email], [PhoneNumber], [Password], [NameFirst], [NameMiddle], [NameLast], [Gender], [DateBirth], [AddressApartment], [AddressStreet], [AddressDistrict], [AddressCity], [BuyPoints], [DateCreate], [DateModify]) VALUES (1, 4, N'hauxuan94@gmail.com', N'0968467519', N'0968467519', N'Hậu', N'Xuân', N'Vũ', N'Nam', CAST(N'1999-06-20 00:00:00.0000000' AS DateTime2), N'p8', N'266 ton dản', N'q4', N'HCM', 100, CAST(N'2019-02-02 00:00:00.0000000' AS DateTime2), CAST(N'2019-02-02 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Users] OFF
SET IDENTITY_INSERT [dbo].[Carts] ON 

INSERT [dbo].[Carts] ([Id], [User_Id], [CartStatus_Id], [TotalPrice], [TotalQuantity], [DateCreate], [DateModify]) VALUES (1, 1, 2, 1379400, 6, CAST(N'2019-12-09 19:22:46.5353485' AS DateTime2), CAST(N'2019-12-09 19:22:46.5356866' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Carts] OFF
SET IDENTITY_INSERT [dbo].[OrderStatuses] ON 

INSERT [dbo].[OrderStatuses] ([Id], [Status]) VALUES (1, N'waiting')
INSERT [dbo].[OrderStatuses] ([Id], [Status]) VALUES (2, N'checking')
INSERT [dbo].[OrderStatuses] ([Id], [Status]) VALUES (3, N'picking')
INSERT [dbo].[OrderStatuses] ([Id], [Status]) VALUES (4, N'transfering')
INSERT [dbo].[OrderStatuses] ([Id], [Status]) VALUES (5, N'completed')
SET IDENTITY_INSERT [dbo].[OrderStatuses] OFF
SET IDENTITY_INSERT [dbo].[PayStatuses] ON 

INSERT [dbo].[PayStatuses] ([Id], [Status]) VALUES (1, N'notyet')
INSERT [dbo].[PayStatuses] ([Id], [Status]) VALUES (2, N'paid')
SET IDENTITY_INSERT [dbo].[PayStatuses] OFF
SET IDENTITY_INSERT [dbo].[PayTypes] ON 

INSERT [dbo].[PayTypes] ([Id], [Type]) VALUES (1, N'cash')
INSERT [dbo].[PayTypes] ([Id], [Type]) VALUES (2, N'paypal')
INSERT [dbo].[PayTypes] ([Id], [Type]) VALUES (3, N'nganluong')
SET IDENTITY_INSERT [dbo].[PayTypes] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [User_Id], [OrderStatus_Id], [PayType_Id], [PayStatus_Id], [PhoneNumber], [TotalPrice], [NameFirst], [NameMiddle], [NameLast], [AddressApartment], [AddressStreet], [AddressDistrict], [AddressCity], [DateCreate], [DateModify]) VALUES (2, 1, 1, 1, 1, N'0968467519', 53100, N'Hậu', N'Xuân', N'Vũ', N'p8', N'266 ton dản', N'q4', N'HCM', CAST(N'2019-12-09 19:23:18.1135461' AS DateTime2), CAST(N'2019-12-09 19:23:18.1135473' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([Id], [Role_Id], [Username], [Password], [Email], [DateCreate], [DateModify]) VALUES (1, 1, N'hauvx', N'hauvx', N'hauxuan94@gmail.com@gmail.com', CAST(N'2019-10-25 21:00:00.0000000' AS DateTime2), CAST(N'2019-10-25 21:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Admins] OFF
SET IDENTITY_INSERT [dbo].[Slugs] ON 

INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (1, N'mat-na-giup-san-chac-the-solution-firming-face-mask-set-10pcs', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (2, N'mat-na-tay-da-chet-chan-smile-foot-feeling-mask-20mlx2', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (3, N'tinh-chat-chong-lao-hoa-green-natural-seed-anti-oxid-essence-50ml', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (4, N'tinh-chat-duong-cung-cap-am', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (5, N'layering-cover-cushion-concealing-base', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (6, N'bb-cushion-pore-control', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (7, N'bb-cushion-anti-aging-spf-50-pa-refill', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (8, N'cream-skin-refiner', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (9, N'time-freeze-skin-refiner', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (10, N'water-back-moisture-cream-ex', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (12, N'cica-sleeping-mask', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (13, N'fresh-calming-quick-morning-mask', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (14, N'sua-rua-mat-ngan-ngua-lao-hoa-cao-cap-ponds-age-miracle', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (15, N'ponds-age-miracle', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (16, N'tone-up-no-sebum-sunscreen-spf35-pa-50ml', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (17, N'auto-eyebrow-pencil-0.3g', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (18, N'green-barley-peeling-essence-50ml', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (19, N'bija-cica-balm-ex-40ml', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Slugs] ([Id], [Url], [DateCreate], [DateModify]) VALUES (20, N'suong', CAST(N'2019-12-09 14:05:45.9041033' AS DateTime2), CAST(N'2019-12-09 14:05:45.9041984' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Slugs] OFF
SET IDENTITY_INSERT [dbo].[ProductBrands] ON 

INSERT [dbo].[ProductBrands] ([Id], [Admin_Id], [Name], [DateCreate], [DateModify]) VALUES (3, 1, N'SEED LINE', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[ProductBrands] ([Id], [Admin_Id], [Name], [DateCreate], [DateModify]) VALUES (4, 1, N'LANEIGE', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[ProductBrands] ([Id], [Admin_Id], [Name], [DateCreate], [DateModify]) VALUES (5, 1, N'POND''s', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[ProductBrands] ([Id], [Admin_Id], [Name], [DateCreate], [DateModify]) VALUES (6, 1, N'INNISFREE', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProductBrands] OFF
SET IDENTITY_INSERT [dbo].[ProductTypes] ON 

INSERT [dbo].[ProductTypes] ([Id], [Admin_Id], [Type], [DateCreate], [DateModify], [URL]) VALUES (1, 1, N'MẶT NẠ', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), N'mat-na')
INSERT [dbo].[ProductTypes] ([Id], [Admin_Id], [Type], [DateCreate], [DateModify], [URL]) VALUES (2, 1, N'TINH CHẤT', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), N'tinh-chat')
INSERT [dbo].[ProductTypes] ([Id], [Admin_Id], [Type], [DateCreate], [DateModify], [URL]) VALUES (3, 1, N'NƯỚC HOA HỒNG', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), N'nuoc-hoa-hong')
INSERT [dbo].[ProductTypes] ([Id], [Admin_Id], [Type], [DateCreate], [DateModify], [URL]) VALUES (4, 1, N'KEM DƯỠNG', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), N'kem-duong')
INSERT [dbo].[ProductTypes] ([Id], [Admin_Id], [Type], [DateCreate], [DateModify], [URL]) VALUES (5, 1, N'SỮA RỬA MẶT', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), N'sua-rua-mat')
INSERT [dbo].[ProductTypes] ([Id], [Admin_Id], [Type], [DateCreate], [DateModify], [URL]) VALUES (6, 1, N'KEM CHỐNG NẮNG', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), N'kem-chong-nang')
INSERT [dbo].[ProductTypes] ([Id], [Admin_Id], [Type], [DateCreate], [DateModify], [URL]) VALUES (7, 1, N'TRANG ĐIỂM MẮT', CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), N'trang-diem-mat')
SET IDENTITY_INSERT [dbo].[ProductTypes] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (2, 3, 1, 1, 1, N'Mặt Nạ Giúp Da Săn Chắc THE SOLUTION FIRMING FACE MASK (SET 10PCS)', N'
-Mặt nạ giấy THE SOLUTION FIRMING FACE MASK sẽ phục hồi sắc da tối màu cũng như cung
 cấp độ ẩm đã bị mất đi, giúp mang đến làn da tươi sáng, mịn màng và tươi trẻ sau khi sử dụng.
-Đặc biệt, chất liệu giấy siêu nhẹ và mỏng chỉ 0.21mm tạo cảm giác mềm mại như lụa và nhẹ nhàng khi sử dụng.', 59000, 10, N'MN11.JPG', 150, 4, 150, 2000, 10, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (3, 3, 1, 2, 1, N'Mặt Nạ Tẩy Da Chết Chân SMILE FOOT PEELING MASK (20mlx2)', N'Sản phẩm nuông chiều đôi chân của bạn bằng cách làm sạch da chết, loại bỏ các vết chai sần, khô nứt nẻ và nuôi dưỡng làn da sáng mịn hồng hào. Smile Foot Peeling Mask sẽ tống khứ các vi khuẩn, độc tố tích tụ tại bàn chân, làm rơi các mảng da chết sần sùi bằng axit AHA tự nhiên trong chanh và táo. Sau khi là bong tróc các lớp da sần sùi bên ngoài, nơi gót chân mặt nạ Smile Foot Peeling Mask sẽ làm mềm và hồng hào vùng da mới.', 620000, 10, N'MN12.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (4, 3, 2, 3, 1, N'Tinh Chất Chống Lão Hóa GREEN NATURAL SEED ANTI OXID ESSENCE 50ml', N'Green Natural Seed Anti Oxid Essence là tinh chất dưỡng da tự nhiên từ Yến mạch xanh cùng các tinh dầu thực vật giúp chống lão hóa chuyên sâu, phục hồi những dấu hiệu hư tổn và thúc đẩy làn da đổi mới nhanh chóng. Nhờ đó, những làn da bị tổn thương hoặc bước qua tuổi 25 sẽ được bảo vệ từ bên trong, duy trì vẻ trẻ đẹp lâu hơn.

Đầu tiên, serum là sản phẩm chăm sóc da chuyên sâu mà phụ nữ cần áp dụng vào quy trình dưỡng da hằng ngày. Đặc biệt là những chị em bước qua tuổi 25 khi làn da bắt đầu xuất hiện các dấu hiệu lão hóa thì việc dùng Tinh chất chống lão hóa Green Natural Seed sẽ giúp da chống lại hiện tượng này từ bên trong.', 759000, 12, N'TC11.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (5, 6, 7, 4, 1, N'Tinh Chất Dưỡng Cung Cấp Ẩm, Làm Trắng Da THEFACESHOP CHIA SEED MOISTURE RECHARGE SERUM', N'Hạt Chia hay còn gọi là Chia Seed là một loại siêu thực phẩm có nguồn gốc lâu đời được các thổ dân Châu Mỹ sử dụng. Ngày nay, hạt Chia được giới y học và dinh dưỡng học xếp loại là một trong những thực phẩm giá trị bậc nhất cho sức khỏe con người, với các đặc điểm nổi trội là giàu omega 3 và canxi cũng như các vitamin và khoáng chất có lợi khác không chỉ cho cơ thể mà còn mang đến hiệu quả chăm sóc làm đẹp da.

Dòng sản phẩm CHIA SEED giúp chăm sóc dịu nhẹ, bổ sung và lưu giữ độ ẩm lâu dài cho da. Đồng thời giúp làm sáng  da thật nhẹ nhàng và tự nhiên, ngăn ngừa hình thành gốc tự do để mang đến hiệu quả chống lão hóa da tuyệt vời.

Thành phần', 659000, 15, N'TC12.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (6, 4, 3, 5, 1, N'Layering Cover Cushion & Concealing Base', N'Sự hòa quyện tuyệt vời giữa phấn nước và kem che khuyết điểm.  Phấn nước 2
trong 1 cung cấp hoàn hảo độ tươi sáng cho da và giúp làn da không bị xỉn màu, lâu trôi.', 700000, 13, N'BB21.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (7, 4, 3, 6, 1, N'BB Cushion Pore Control', N'Khả năng kiềm dầu mạnh mẽ! Lớp nền ẩm mịn bên trong và đều màu bên ngoài trong suốt nhiều giờ liền', 930000, 13, N'BB22.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (8, 4, 3, 7, 1, N'BB Cushion Anti-aging SPF 50+ PA+++ Refill', N'Vỗ thật nhẹ, bền thật lâu nhờ khả năng che phủ vượt trội của kem nền đa năng cho lớp nền hoàn hảo dài lâu.', 570000, 8, N'BB23.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (9, 4, 4, 8, 1, N'Cream Skin Refiner', N'Nước cân bằng giúp dưỡng ẩm mang lại cho da nguồn
dưỡng chất tự nhiên và dưỡng ẩm da hiệu quả', 600000, 10, N'NHH21.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (10, 4, 4, 9, 1, N'Time Freeze Skin Refiner', N'Nước cân bằng giúp ngăn ngừa lão hóa da hiệu quả nhờ vào khả năng giúp cho da đàn hồi, mềm mại, và sáng hồng rạng rỡ.', 950000, 15, N'NHH22.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (11, 4, 5, 10, 1, N'Water Bank Moisture Cream EX', N'Kem dưỡng ẩm với thành phần nước khoáng xanh, giúp tái tạo độ ẩm vốn có của da đồng thời củng cố hàng rào bảo vệ da mang đến làn da mềm mịn', 850000, 0, N'KD21.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (13, 4, 1, 12, 1, N'Cica Sleeping Mask', N'Mặt nạ ngủ giúp cung cấp chất dưỡng ẩm sâu và bảo vệ da suốt đêm dài,
mang lại một làn da tươi mới, tràn đầy sức sống vào sáng hôm sau.', 720000, 15, N'MN21.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (14, 4, 1, 13, 1, N'Fresh Calming Quick Morning Mask', N'Mặt nạ dưỡng ẩm vào buổi sáng tiện lợi và dễ dàng giúp dưỡng ẩm và tạo cảm giác dịu nhẹ cho làn da trước khi trang điểm', 570000, 10, N'MN22.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (15, 5, 7, 14, 1, N'Sữa Rửa Mặt Ngăn Ngừa Lão Hóa Cao cấp Ponds Age Miracle', N'Lấy lại làn da tươi trẻ rạng ngời. Với các thành phần đặc biệt giúp thúc đẩy khả năng tái tạo da hiệu quả, sản phẩm sữa rửa mặt hằng ngày này chứa các hạt hoạt chất li ti - giúp làm sạch lớp tế bào chết hình thành trên bề mặt da.', 57000, 0, N'SRM31.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (16, 4, 6, 15, 1, N'Ponds Age Miracle', N'Trong khi công việc ngày càng nhiều áp lực, còn thời gian để chăm sóc da ngày càng ít, giải pháp cho những nếp nhăn tiềm ẩn ở đuôi mắt mỗi khi bạn cười chính là Kem Ngăn Ngừa Lão Hóa Ponds Age Miracle cho vùng mắt.', 500000, 0, N'KD31.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (17, 4, 6, 16, 1, N'Tone Up No Sebum Sunscreen SPF35 PA+++ 50ml', N'Kem chống nắng chứa thành phần kem nền giúp da không bóng nhẫy mà vẫn giữ vẻ mềm mại mịn màng', 330000, 5, N'KCN41.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (18, 4, 7, 17, 1, N'Auto Eyebrow Pencil 0.3g', N'Chì dùng trang điểm chân mày.', 99000, 15, N'TDM41.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (19, 5, 2, 18, 1, N'Green barley peeling essence 50ml', N'Tinh dầu tẩy tế bào chết dịu nhẹ hàng ngày loại không rửa giúp nhẹ nhàng loại bỏ các tế bào da chết và tạp chất hàng ngày và khiến làn da trở nên mịn màng và tươi sáng', 420000, 10, N'TC41.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductBrand_Id], [ProductType_Id], [Slug_Id], [Admin_Id], [Name], [Description], [Price], [Saleoff], [Thumbnail], [Instore], [Stars], [BuyPoints], [Views], [Orders], [DateCreate], [DateModify], [Article]) VALUES (20, 6, 2, 19, 1, N'Bija Cica Balm EX 40ml', N'Dầu thơm dạng gel giúp làm dịu làn da nhạy cảm và chăm sóc những vùng da bị tổn thương', 520000, 5, N'TC42.JPG', 150, 4, 150, 2001, 20, CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), CAST(N'2019-12-08 00:00:00.0000000' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[AnoCartDetails] ON 

INSERT [dbo].[AnoCartDetails] ([Id], [Cart_Id], [Product_Id], [Quantity], [PriceSingle], [PriceTotal], [DateCreate], [DateModify]) VALUES (1, 1, 2, 1, 53100, 53100, CAST(N'2019-12-09 21:04:44.2491181' AS DateTime2), CAST(N'2019-12-09 21:04:44.2493614' AS DateTime2))
INSERT [dbo].[AnoCartDetails] ([Id], [Cart_Id], [Product_Id], [Quantity], [PriceSingle], [PriceTotal], [DateCreate], [DateModify]) VALUES (3, 3, 3, 1, 558000, 558000, CAST(N'2019-12-09 22:14:57.4696616' AS DateTime2), CAST(N'2019-12-09 22:14:57.4697880' AS DateTime2))
INSERT [dbo].[AnoCartDetails] ([Id], [Cart_Id], [Product_Id], [Quantity], [PriceSingle], [PriceTotal], [DateCreate], [DateModify]) VALUES (4, 3, 2, 1, 53100, 53100, CAST(N'2019-12-09 22:18:41.6070963' AS DateTime2), CAST(N'2019-12-09 22:18:41.6070980' AS DateTime2))
SET IDENTITY_INSERT [dbo].[AnoCartDetails] OFF
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([Id], [Order_Id], [Product_Id], [Quantity], [PriceSingle], [PriceTotal]) VALUES (2, 2, 3, 1, 558000, 558000)
INSERT [dbo].[OrderDetails] ([Id], [Order_Id], [Product_Id], [Quantity], [PriceSingle], [PriceTotal]) VALUES (3, 2, 2, 1, 53100, 53100)
INSERT [dbo].[OrderDetails] ([Id], [Order_Id], [Product_Id], [Quantity], [PriceSingle], [PriceTotal]) VALUES (4, 2, 6, 1, 609000, 609000)
INSERT [dbo].[OrderDetails] ([Id], [Order_Id], [Product_Id], [Quantity], [PriceSingle], [PriceTotal]) VALUES (5, 2, 2, 1, 53100, 53100)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191208034009_Init', N'2.2.6-servicing-10079')
