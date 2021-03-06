USE [HotelBooking]
GO
/****** Object:  Table [dbo].[Hotel_Booking]    Script Date: 7/3/2022 10:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel_Booking](
	[Booking_ID] [int] IDENTITY(1,1) NOT NULL,
	[Hotel_ID] [int] NULL,
	[Hotel_BookBy] [int] NULL,
	[Hotel_BookingDate] [datetime] NULL,
	[Hotel_Checkout] [datetime] NULL,
	[Hotel_CustomerName] [nvarchar](200) NULL,
	[Hotel_CustomerIdentification] [nvarchar](500) NULL,
 CONSTRAINT [PK_Hotel_Booking] PRIMARY KEY CLUSTERED 
(
	[Booking_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hotel_Master]    Script Date: 7/3/2022 10:21:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel_Master](
	[Hotel_ID] [int] IDENTITY(1,1) NOT NULL,
	[Hotel_Name] [nvarchar](100) NULL,
	[Hotel_Address] [nvarchar](300) NULL,
	[Hotel_Description] [nvarchar](300) NULL,
	[Hotel_Ratings] [int] NULL,
	[Hotel_Review] [int] NULL,
	[Hotel_Facilities] [nvarchar](200) NULL,
	[Hotel_Charges] [int] NULL,
	[Hotel_AddedBy] [int] NULL,
	[Hotel_AddedDatetime] [datetime] NULL,
	[Hotel_Status] [bit] NULL,
	[Hotel_Rooms] [int] NULL,
	[Hotel_Image_1] [nvarchar](max) NULL,
	[Hotel_Image_2] [nvarchar](max) NULL,
	[Hotel_Image_3] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Hotel_Booking] ON 

INSERT [dbo].[Hotel_Booking] ([Booking_ID], [Hotel_ID], [Hotel_BookBy], [Hotel_BookingDate], [Hotel_Checkout], [Hotel_CustomerName], [Hotel_CustomerIdentification]) VALUES (1, 1, 1, CAST(N'2022-07-03T00:00:00.000' AS DateTime), CAST(N'2022-07-05T00:00:00.000' AS DateTime), N'Test Customer', N'Passport')
INSERT [dbo].[Hotel_Booking] ([Booking_ID], [Hotel_ID], [Hotel_BookBy], [Hotel_BookingDate], [Hotel_Checkout], [Hotel_CustomerName], [Hotel_CustomerIdentification]) VALUES (2, 1, 1, CAST(N'2022-07-03T00:00:00.000' AS DateTime), CAST(N'2022-07-05T00:00:00.000' AS DateTime), N'Test Customer', N'Passport')
SET IDENTITY_INSERT [dbo].[Hotel_Booking] OFF
GO
SET IDENTITY_INSERT [dbo].[Hotel_Master] ON 

INSERT [dbo].[Hotel_Master] ([Hotel_ID], [Hotel_Name], [Hotel_Address], [Hotel_Description], [Hotel_Ratings], [Hotel_Review], [Hotel_Facilities], [Hotel_Charges], [Hotel_AddedBy], [Hotel_AddedDatetime], [Hotel_Status], [Hotel_Rooms], [Hotel_Image_1], [Hotel_Image_2], [Hotel_Image_3]) VALUES (1, N'Hotel Luxuxy 1', N'Burjuman', N'A prime location Hotel', 4, 35, N'Wifi, Breakfast, Spa', 250, 1, CAST(N'2022-07-03T20:04:22.900' AS DateTime), 1, 1, NULL, NULL, NULL)
INSERT [dbo].[Hotel_Master] ([Hotel_ID], [Hotel_Name], [Hotel_Address], [Hotel_Description], [Hotel_Ratings], [Hotel_Review], [Hotel_Facilities], [Hotel_Charges], [Hotel_AddedBy], [Hotel_AddedDatetime], [Hotel_Status], [Hotel_Rooms], [Hotel_Image_1], [Hotel_Image_2], [Hotel_Image_3]) VALUES (2, N'Hotel Luxuxy 2', N'Burjuman 2', N'A prime location Hotel', 3, 20, N'Wifi, Breakfast, Spa,Parking', 200, 1, CAST(N'2022-07-03T20:05:00.767' AS DateTime), 1, 1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Hotel_Master] OFF
GO
ALTER TABLE [dbo].[Hotel_Master] ADD  DEFAULT ((1)) FOR [Hotel_AddedBy]
GO
ALTER TABLE [dbo].[Hotel_Master] ADD  DEFAULT (getdate()) FOR [Hotel_AddedDatetime]
GO
ALTER TABLE [dbo].[Hotel_Master] ADD  DEFAULT ((1)) FOR [Hotel_Status]
GO
ALTER TABLE [dbo].[Hotel_Master] ADD  DEFAULT ((1)) FOR [Hotel_Rooms]
GO
