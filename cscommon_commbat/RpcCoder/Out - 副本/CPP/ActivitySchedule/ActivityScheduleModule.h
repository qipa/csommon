﻿/********************************************************************************************
* Copyright (C), 2011-2025, AGAN Tech. Co., Ltd.
* FileName:     ModuleActivitySchedule.h
* Author:       甘业清
* Description:  活动日常类，包含以下内容
*               ★模块基本信息函数
*               ★初始化结束回调函数
*               ★时间相当回调函数
*               ★用户创建上下线回调函数
*               ★模块数据修改及同步回调函数
*               ★服务器后台RPC函数
*               ★客户端RPC函数
* Version:      1.0
* History:
* <author>  <time>   <version >   <desc>
* 
********************************************************************************************/

#ifndef __MODULE_ACTIVITYSCHEDULE_H
#define __MODULE_ACTIVITYSCHEDULE_H


#include "ModuleBase.h"
#include "ActivityScheduleRpcWraper.h"
#include "ActivityScheduleV1Data.h"
#include "ActivityScheduleV1DataWraper.h"




//活动日常实现类
class ModuleActivitySchedule : public ModuleBase
{
	DECLARE_INSTANCE(ModuleActivitySchedule);
public:
	friend class			ModuleMgr;

public:
	//活动日常实现类构造函数
	ModuleActivitySchedule();
	
	//活动日常实现类析构函数
	virtual					~ModuleActivitySchedule();

	//获取模块ID
	virtual	UINT8			GetModuleId();
	
	//获取模块名字
	virtual	TStr			GetModuleName();
	
	//获取模块同步(保存)数据版本及类名
	virtual map<INT32,TStr>	GetModuleDataVersionName();
	
	//模块数据保存类型
	virtual SavedDataTypeE	GetSavedDataType();

	//获取初始化顺序
	virtual int				GetInitializeOrder();
	
	//获取结束退出顺序
	virtual int				GetFinalizeOrder();
	
	//初始化
	virtual bool			Initialize();
	
	//结束退出
	virtual void			Finalize();

	//毫秒级Tick回调
	virtual void			OnTick( INT64 currentMiliSecond );
	
	//秒级Tick回调
	virtual void			OnSecondTick( time_t currentSecond );
	
	//分钟改变回调
	virtual void			OnMinuteChange( time_t currentSecond);
	
	//小时改变回调
	virtual void			OnHourChange( time_t currentSecond );
	
	//天改变回调
	virtual void			OnDayChange( time_t currentSecond );

	//创建用户回调
	virtual void			OnUserCreate( INT64 userId, const TStr& userName );
	
	//用户上线回调
	virtual void			OnUserOnline( INT64 userId, time_t lastLogoutTime );
	
	//用户下线回调
	virtual void			OnUserOffline( INT64 userId );

	//是否要同步数据到客户端
	virtual bool			NotSyncToClient( UINT16 usSyncId );
	
	//同步数据修改后回调
	virtual void			NotifySyncValueChanged(INT64 Key,UINT16 usSyncId, int nIndex=-1);

public:
	/********************************************************************************************
	* Function:       RpcSyncData
	* Description:    活动日常-->活动日常数据同步调用操作函数
	* Input:          ActivityScheduleRpcSyncDataAskWraper& Ask 活动日常数据请求
	* Output:         ActivityScheduleRpcSyncDataReplyWraper& Reply 活动日常数据回应
	* Return:         int 高16位为系统返回值RpcCallErrorCodeE，获取方法GET_RPC_ERROR_CODE(ret) 
	*                     低16位为操作返回值，获取方法GET_OPERATION_RET_CODE(ret)
	********************************************************************************************/
	virtual int RpcSyncData( INT64 UserId, ActivityScheduleRpcSyncDataAskWraper& Ask, ActivityScheduleRpcSyncDataReplyWraper& Reply );

	/********************************************************************************************
	* Function:       SendToClientThiefBeOpened
	* Description:    活动日常-->江洋大盗被开启通知异步通知操作函数
	* Input:          ActivityScheduleRpcThiefBeOpenedNotifyWraper& Notify 江洋大盗被开启通知通知
	* Input:          INT64 UserId 需要通知到的用户ID
	* Output:         无
	* Return:         无
	********************************************************************************************/
	virtual void SendToClientThiefBeOpened( INT64 UserId, ActivityScheduleRpcThiefBeOpenedNotifyWraper& Notify );

	/********************************************************************************************
	* Function:       SendToClientThiefRefresh
	* Description:    活动日常-->江洋大盗刷新异步通知操作函数
	* Input:          ActivityScheduleRpcThiefRefreshNotifyWraper& Notify 江洋大盗刷新通知
	* Input:          INT64 UserId 需要通知到的用户ID
	* Output:         无
	* Return:         无
	********************************************************************************************/
	virtual void SendToClientThiefRefresh( INT64 UserId, ActivityScheduleRpcThiefRefreshNotifyWraper& Notify );

	/********************************************************************************************
	* Function:       RpcThiefOpenMonster
	* Description:    活动日常-->江洋大盗开怪同步调用操作函数
	* Input:          ActivityScheduleRpcThiefOpenMonsterAskWraper& Ask 江洋大盗开怪请求
	* Output:         ActivityScheduleRpcThiefOpenMonsterReplyWraper& Reply 江洋大盗开怪回应
	* Return:         int 高16位为系统返回值RpcCallErrorCodeE，获取方法GET_RPC_ERROR_CODE(ret) 
	*                     低16位为操作返回值，获取方法GET_OPERATION_RET_CODE(ret)
	********************************************************************************************/
	virtual int RpcThiefOpenMonster( INT64 UserId, ActivityScheduleRpcThiefOpenMonsterAskWraper& Ask, ActivityScheduleRpcThiefOpenMonsterReplyWraper& Reply );

	/********************************************************************************************
	* Function:       RpcSubdueMonsterEnter
	* Description:    活动日常-->降妖进入副本同步调用操作函数
	* Input:          ActivityScheduleRpcSubdueMonsterEnterAskWraper& Ask 降妖进入副本请求
	* Output:         ActivityScheduleRpcSubdueMonsterEnterReplyWraper& Reply 降妖进入副本回应
	* Return:         int 高16位为系统返回值RpcCallErrorCodeE，获取方法GET_RPC_ERROR_CODE(ret) 
	*                     低16位为操作返回值，获取方法GET_OPERATION_RET_CODE(ret)
	********************************************************************************************/
	virtual int RpcSubdueMonsterEnter( INT64 UserId, ActivityScheduleRpcSubdueMonsterEnterAskWraper& Ask, ActivityScheduleRpcSubdueMonsterEnterReplyWraper& Reply );

	/********************************************************************************************
	* Function:       SendToClientSubdueMonsterBeOpened
	* Description:    活动日常-->降妖被其他人开启异步通知操作函数
	* Input:          ActivityScheduleRpcSubdueMonsterBeOpenedNotifyWraper& Notify 降妖被其他人开启通知
	* Input:          INT64 UserId 需要通知到的用户ID
	* Output:         无
	* Return:         无
	********************************************************************************************/
	virtual void SendToClientSubdueMonsterBeOpened( INT64 UserId, ActivityScheduleRpcSubdueMonsterBeOpenedNotifyWraper& Notify );

	/********************************************************************************************
	* Function:       SendToClientSubdueMonsterRefresh
	* Description:    活动日常-->降妖除魔刷新Npc异步通知操作函数
	* Input:          ActivityScheduleRpcSubdueMonsterRefreshNotifyWraper& Notify 降妖除魔刷新Npc通知
	* Input:          INT64 UserId 需要通知到的用户ID
	* Output:         无
	* Return:         无
	********************************************************************************************/
	virtual void SendToClientSubdueMonsterRefresh( INT64 UserId, ActivityScheduleRpcSubdueMonsterRefreshNotifyWraper& Notify );

	/********************************************************************************************
	* Function:       RpcWorldBossEnterDungeon
	* Description:    活动日常-->世界Boss进行副本同步调用操作函数
	* Input:          ActivityScheduleRpcWorldBossEnterDungeonAskWraper& Ask 世界Boss进行副本请求
	* Output:         ActivityScheduleRpcWorldBossEnterDungeonReplyWraper& Reply 世界Boss进行副本回应
	* Return:         int 高16位为系统返回值RpcCallErrorCodeE，获取方法GET_RPC_ERROR_CODE(ret) 
	*                     低16位为操作返回值，获取方法GET_OPERATION_RET_CODE(ret)
	********************************************************************************************/
	virtual int RpcWorldBossEnterDungeon( INT64 UserId, ActivityScheduleRpcWorldBossEnterDungeonAskWraper& Ask, ActivityScheduleRpcWorldBossEnterDungeonReplyWraper& Reply );

	/********************************************************************************************
	* Function:       RpcWorldBossSyncData
	* Description:    活动日常-->世界Boss,打开界面刷新数据同步调用操作函数
	* Input:          ActivityScheduleRpcWorldBossSyncDataAskWraper& Ask 世界Boss,打开界面刷新数据请求
	* Output:         ActivityScheduleRpcWorldBossSyncDataReplyWraper& Reply 世界Boss,打开界面刷新数据回应
	* Return:         int 高16位为系统返回值RpcCallErrorCodeE，获取方法GET_RPC_ERROR_CODE(ret) 
	*                     低16位为操作返回值，获取方法GET_OPERATION_RET_CODE(ret)
	********************************************************************************************/
	virtual int RpcWorldBossSyncData( INT64 UserId, ActivityScheduleRpcWorldBossSyncDataAskWraper& Ask, ActivityScheduleRpcWorldBossSyncDataReplyWraper& Reply );



private:
	 map<INT32,TStr>		m_mapSyncDataVersionName;
};

#endif