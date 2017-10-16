﻿/********************************************************************************************
* Copyright (C), 2011-2025, AGAN Tech. Co., Ltd.
* FileName:     GuildDBCache.h
* Author:       甘业清
* Description:  帮派数据类
* Version:      1.0
* History:
* <author>  <time>   <version >   <desc>
* 
********************************************************************************************/

#ifndef __DATA_GUILD_H
#define __DATA_GUILD_H


#include "ModuleData.h"
#include "GuildV1DataWraper.h"


//同步数据相关枚举量定义
enum DataWraperItemIdE
{
	MODULE_ID_GUILD = 34,
 	SYNCID_GUILD_GUILDDATA                      = 3401,  //帮会数据

};


//帮派数据类
class DataGuild : public ModuleData
{
	DECLARE_INSTANCE(DataGuild);
public:
	friend class			ModuleDataMgr;

public:
	//帮派实现类构造函数
	DataGuild();
	
	//帮派实现类析构函数
	virtual					~DataGuild();

	//获取模块ID
	virtual	UINT8			GetModuleId();
	
	//获取模块名字
	virtual	TStr			GetModuleName();
	
	//获取模块同步(保存)数据版本及类名
	virtual map<INT32,TStr>	GetDataWraperVersionName();
	
	//模块数据保存类型
	virtual SavedDataTypeE	GetSavedDataType();

	//是否保存数据到数据库中
	virtual bool			IsSaveModuleDataToDB();

	//模块同步(保存)数据升级函数
	virtual bool			UpdateModuleData(ModuleDataInterface* pre, ModuleDataInterface* cur );
	
	//增量更新通知
	virtual bool			OnIncrementUpdate( INT64 key, int syncId, int IndexPos, const char* pBuffer, int dataLen );


private:
	 map<INT32,TStr>		m_mapDataWraperVersionName;
};

#endif