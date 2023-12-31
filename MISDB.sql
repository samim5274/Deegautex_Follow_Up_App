USE [MISDB]
GO
/****** Object:  Table [dbo].[FollowUpTable]    Script Date: 6/20/2023 4:01:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FollowUpTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FollowUp] [varchar](200) NULL,
	[Remark] [varchar](500) NULL,
	[PId] [int] NULL,
 CONSTRAINT [PK_FollowUpTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiveAndReciveDeailTable]    Script Date: 6/20/2023 4:01:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiveAndReciveDeailTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[GiverName] [varchar](100) NULL,
	[ReciverName] [varchar](100) NULL,
	[Time] [varchar](50) NULL,
	[Reson] [varchar](150) NULL,
	[MoneyType] [int] NULL,
	[Money] [int] NULL,
 CONSTRAINT [PK_GiveAndReciveDeailTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurposeInfo]    Script Date: 6/20/2023 4:01:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurposeInfo](
	[PId] [int] NOT NULL,
	[Purpose] [varchar](200) NULL,
 CONSTRAINT [PK_PurposeInfo] PRIMARY KEY CLUSTERED 
(
	[PId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FollowUpTable]  WITH CHECK ADD  CONSTRAINT [FK_FollowUpTable_PurposeInfo] FOREIGN KEY([PId])
REFERENCES [dbo].[PurposeInfo] ([PId])
GO
ALTER TABLE [dbo].[FollowUpTable] CHECK CONSTRAINT [FK_FollowUpTable_PurposeInfo]
GO
/****** Object:  StoredProcedure [dbo].[SP_DAY_WISE_MONEY_REPORT]    Script Date: 6/20/2023 4:01:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		SHAMIM HOSSEN
-- Create date: 20203-06-2019
-- Description:	DAY WISE REPORT
-- =============================================
CREATE PROCEDURE [dbo].[SP_DAY_WISE_MONEY_REPORT]
	 @SDate date ,
	 @EDate date 
AS
BEGIN

	SET NOCOUNT ON;

	SELECT 
				GR.Date,
				GR.GiverName,
				GR.ReciverName,
				GR.Time,
				GR.Reson,
				CASE
					WHEN GR.MoneyType = 0 THEN 'I Give'
					WHEN GR.MoneyType=1 THEN 'I Taking'
					ELSE 'Other'
				END AS Type,
				GR.Money
			FROM GiveAndReciveDeailTable GR

				--GR.Date BETWEEN @SDate AND @EDate

					WHERE GR.Date >= @SDate AND GR.Date<=@EDate

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Follow_Up_Item]    Script Date: 6/20/2023 4:01:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		SAMIM HOSSEN
-- Create date: 13.06.2023
-- Description:	PURPOSE SHOW IN TABLE
-- =============================================
CREATE PROCEDURE [dbo].[SP_Follow_Up_Item]
AS
BEGIN
	
		SELECT 
			FU.Id,
			FU.FollowUp,
			p.Purpose
		FROM FollowUpTable FU

				INNER JOIN PurposeInfo P ON p.PId = FU.PId;  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_FollowUp]    Script Date: 6/20/2023 4:01:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_FollowUp]
AS
BEGIN

	SELECT 
			FUT.Id,
			FUT.FollowUp,
			P.Purpose,
			FUT.Remark		
		FROM FollowUpTable FUT

			INNER JOIN PurposeInfo P ON FUT.PId = P.PId
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Purpose_Wise_Follow_Report]    Script Date: 6/20/2023 4:01:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		samim hossain
-- Create date: 20230615
-- Description:	purpose wise follow up item show or report
-- =============================================
CREATE PROCEDURE [dbo].[SP_Purpose_Wise_Follow_Report]

		@PopId int 

AS

		IF @PopId = 0 SET @PopId =NULL
	
BEGIN
	
	SELECT 
				FUT.Id,
				FUT.FollowUp,
				P.Purpose,
				FUT.Remark		
		FROM FollowUpTable FUT

			INNER JOIN PurposeInfo P ON FUT.PId = P.PId


				WHERE FUT.PId=@PopId
				AND
				CASE 
					WHEN @PopId IS NULL THEN 1
					WHEN @PopId IS NOT NULL AND FUT.Id = @PopId THEN 1
				END =1


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Report]    Script Date: 6/20/2023 4:01:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Report]
@PID INT
AS
IF @PId = 0 SET @PId = NULL
BEGIN

	SET NOCOUNT ON;

			SELECT 
				F.Id,
				p.Purpose,
				F.FollowUp,			
				F.Remark			
			FROM FollowUpTable F

				INNER JOIN PurposeInfo P ON P.PId = F.PId

				WHERE 

				CASE
					WHEN @PID IS NULL THEN 1
					WHEN @PID IS NOT NULL AND F.PId = @PID THEN 1
				END = 1


END
GO
