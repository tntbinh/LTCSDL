USE [News]
GO
/****** Object:  Table [dbo].[DemID]    Script Date: 6/18/2020 7:33:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DemID](
	[countID] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiTin]    Script Date: 6/18/2020 7:33:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTin](
	[IDloaitin] [nvarchar](50) NOT NULL,
	[tenLT] [nchar](200) NULL,
	[thutuLT] [int] NULL,
	[anhienLT] [tinyint] NULL,
	[IDtheloai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiTin] PRIMARY KEY CLUSTERED 
(
	[IDloaitin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 6/18/2020 7:33:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[IDtheloai] [nvarchar](50) NOT NULL,
	[tenTL] [nchar](250) NULL,
	[thutuTL] [int] NULL,
	[anhienTL] [tinyint] NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[IDtheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TinTuc]    Script Date: 6/18/2020 7:33:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinTuc](
	[IDtintuc] [nvarchar](50) NOT NULL,
	[tieude] [nvarchar](250) NULL,
	[tomtat] [nvarchar](250) NULL,
	[noidung] [nvarchar](max) NULL,
	[urlHinh] [nvarchar](250) NULL,
	[ngaydang] [date] NULL,
	[solanxem] [int] NULL,
	[keyword] [nvarchar](200) NULL,
	[tinnoibat] [tinyint] NULL,
	[anhientin] [tinyint] NULL,
	[IDloaitin] [nvarchar](50) NULL,
 CONSTRAINT [PK_TinTuc] PRIMARY KEY CLUSTERED 
(
	[IDtintuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/18/2020 7:33:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[IDuser] [nvarchar](50) NOT NULL,
	[hoten] [nvarchar](150) NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[email] [nvarchar](250) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [tinyint] NULL,
	[IDgroup] [tinyint] NULL,
	[ngaydangky] [date] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[IDuser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  StoredProcedure [dbo].[getMostViewedAtthistime]    Script Date: 6/18/2020 7:33:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin tuc>
-- Create date: <2020-06-16>
-- Description:	<nhap thoi gian bat dau va thoi gian ket thuc xuat ra tin tuc duoc xem nhieu nhat trong khoang thoi gian do>
-- run: exec getMostViewedAtthistime '2020-06-10','2020-09-20'
-- =============================================
Create PROCEDURE [dbo].[getMostViewedAtthistime]
	-- Add the parameters for the stored procedure here
	@datef datetime = null,
	@datet datetime = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT top 1 a.tieude AS tieude, a.solanxem, a.ngaydang
	FROM TinTuc a
	WHERE ngaydang between @datef and @datet
	ORDER BY a.solanxem DESC
END


GO
