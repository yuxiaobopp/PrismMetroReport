USE [EM_Data]
GO
/****** Object:  Table [dbo].[tab_User]    Script Date: 09/18/2014 14:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tab_User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](255) NULL,
	[Password] [nvarchar](255) NULL,
	[Authority] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tab_Syslog]    Script Date: 09/18/2014 14:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tab_Syslog](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[m_UserName] [nvarchar](255) NULL,
	[m_Operate] [nvarchar](max) NULL,
	[m_OperateDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tab_HistoryData]    Script Date: 09/18/2014 14:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tab_HistoryData](                 //历史记录表
	[DataID] [int] IDENTITY(1,1) NOT NULL,		//自动编号（数据库自动生成）
	[DevKey] [nvarchar](50) NULL,//设备KEY（监控软件在仓建设备时自动生成）
        [ItemKey] [nvarchar](50) NULL,//数据KEY 
	[DevName] [nvarchar](50) NULL,//设备名称
	[DevAddress] [nvarchar](50) NULL,//设备 地址
	[DevType] [nvarchar](50) NULL,//设备 类型
	[DevLocation] [nvarchar](255) NULL,//设备位置
	[TransportNumber] [nvarchar](255) NULL,//保留用
	[Longitude] [nvarchar](255) NULL,//经度
	[Latitude] [nvarchar](255) NULL,//纬度
	[Speed] [nvarchar](255) NULL,//速度
	[TempValue] [real] NULL,//温度值
	[HumiValue] [real] NULL,//湿度值
	[DewValue] [real] NULL,//露点值
	[TempAlarmRange] [nvarchar](50) NULL,//温度范围
	[HumiAlarmRange] [nvarchar](255) NULL,//湿度范围
	[DateTime] [datetime] NULL,//保存时间
	[SaveTime] [nvarchar](255) NULL,
	[TempUnit] [nvarchar](255) NULL,//温度单位
	[ParentID] [nvarchar](255) NULL,//父设备 ID
	[Channel] [smallint] NULL//通道号
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tab_DeviceStatus]    Script Date: 09/18/2014 14:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tab_DeviceStatus](
	[DevID] [nvarchar](255) NULL,//设备KEY
	[DevAddr] [nvarchar](255) NULL,//设备 地址
	[DevName] [nvarchar](255) NULL,//设备名称
	[DevModel] [nvarchar](255) NULL,//设备类型
	[DevStatus] [nvarchar](255) NULL,//设备状态
	[DevAlarmStatus] [smallint] NULL,设备 报警状态
	[TempValue] [real] NULL,//温度值
	[HumiValue] [real] NULL,//湿度值
	[TempMaxValue] [real] NULL,//温度最大
	[TempMinValue] [real] NULL,//温度最小
	[TempAvgValue] [real] NULL,//温度平均
	[HumiMaxValue] [real] NULL,//湿度最大
	[HumiMinValue] [real] NULL,//湿度最小
	[HumiAvgValue] [real] NULL,//湿度平均
	[TempMaxAlarm] [real] NULL,//温度上限报警值
	[TempMinAlarm] [real] NULL,//温度下限报警值
	[HumiMaxAlarm] [real] NULL,//湿度上限报警值
	[HumiMinAlarm] [real] NULL//湿度下限报警值
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tab_Class]    Script Date: 09/18/2014 14:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tab_Class](
	[sID] [int] NOT NULL,
	[sParentID] [nvarchar](50) NULL,
	[sName] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tab_AlarmData]    Script Date: 09/18/2014 14:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tab_AlarmData](
	[DataID] [int] IDENTITY(1,1) NOT NULL,
	[DevKey] [nvarchar](50) NULL, //设备 KEY
        [ItemKey] [nvarchar](50) NULL,//数据KEY 
	[DevName] [nvarchar](50) NULL,//设备 名称
	[DevType] [nvarchar](50) NULL,//设备 类型
	[DevAddr] [nvarchar](50) NULL,//设备 地址
	[ParentID] [nvarchar](255) NULL,//父设备 ID
	[Channel] [smallint] NULL,//通道号
	[DevLocation] [nvarchar](255) NULL,//设备 位置
	[AlarmType] [nvarchar](50) NULL,//报警类型
	[DataValue] [real] NULL,//报警值
	[AlarmRange] [nvarchar](50) NULL,//报警范围
	[DateTime] [datetime] NULL,//报警时间
	[HandlingMethod] [nvarchar](255) NULL,//处理方法
	[HandlingUser] [nvarchar](255) NULL,//处理人
	[HandlingTime] [datetime] NULL//处理时间
) ON [PRIMARY]
GO
