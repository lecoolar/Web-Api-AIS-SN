﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_AIS_SN.GKH;
using Web_API_AIS_SN.LK;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.NoticeAndReport;
using Web_API_AIS_SN.SMSR;

namespace Web_API_AIS_SN.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SMSRServiceController : ControllerBase
    {
        
        [HttpPost]
        [Route("ReturnResponseData")]
        public async Task<ActionResult<ResponseData>> ReturnResponseData(GKH.Request request)
        {
            List<Dictionary<string, object>> qwerty = new List<Dictionary<string, object>>();
                ResponseData result = new ResponseData();
            switch (request.MetodRequest)
            {
                case "AccountInfo":
                    GKH.AccountInfo accountInfo = new GKH.AccountInfo(request.@params);
                    result = await accountInfo.GetAccountInfo();                   
                    break;
                case "GetAccountsByFiasHouseAndRoom":
                    AccountsByFiasHouseAndRoom accountsByFiasHouseAndRoom = new AccountsByFiasHouseAndRoom(request.@params);
                    result = await accountsByFiasHouseAndRoom.GetAccountsByFiasHouseAndRoom();
                    break;
                case "AccountServiceInfo":
                    AccountServiceInfo accountServiceInfo = new AccountServiceInfo(request.@params);
                    result = await accountServiceInfo.GetAccountServiceInfo();
                    break;
                case "FindTypeReport":
                    FindTypeReport findTypeReport = new FindTypeReport(request.@params);
                    result = await findTypeReport.GetFindTypeReport();
                    break;
                case "GetOperationJournal":
                    OperationJournal operationJournal = new OperationJournal(request.@params);
                    result = await operationJournal.GetOperationJournal();
                    break;
                case "GroupOperationInfo":
                    GroupOperationInfo groupOperationInfo = new GroupOperationInfo(request.@params);
                    result = await groupOperationInfo.GetGroupOperationInfo();
                    break;
                case "GetConsumption":
                    Consumption consumption = new Consumption(request.@params);
                    result = await consumption.GetConsumption();
                    break;
                case "GetLocalAddress":
                    LocalAddress localAddress = new LocalAddress(request.@params);
                    result = await localAddress.GetLocalAddress();
                    break;
                case "GetAcocuntByLocalAddress":
                    AcocuntByLocalAddress acocuntByLocalAddress = new AcocuntByLocalAddress(request.@params);
                    result = await acocuntByLocalAddress.GetAcocuntByLocalAddress();
                    break;
                case "BilledAmounts":
                    BilledAmounts billedAmounts = new BilledAmounts(request.@params);
                    result = await billedAmounts.GetBilledAmounts();
                    break;
                case "GetCountResidents":
                    CountResidents countResidents = new CountResidents(request.@params);
                    result = await countResidents.GetCountResidents();
                    break;
                case "GetCountResidentVacation":
                    CountResidentVacation countResidentVacation = new CountResidentVacation(request.@params);
                    result = await countResidentVacation.GetCountResidentVacation();
                    break;
                case "GetFasets":
                    Fasets fasets = new Fasets(request.@params);
                    result = await fasets.GetFasets();
                    break;
                case "GetFasetItems":
                    FasetItems fasetItems = new FasetItems(request.@params);
                    result = await fasetItems.GetFasetItems();
                    break;
                case "GetResidents":
                    Residents residents = new Residents(request.@params);
                    result = await residents.GetResidents();
                    break;
                case "GetResidentVacation":
                    ResidentVacation residentVacation = new ResidentVacation(request.@params);
                    result = await residentVacation.GetResidentVacation();
                    break;
                case "GetHouseHolderByFias":
                    HouseHolderByFias houseHolderByFias = new HouseHolderByFias(request.@params);
                    result = await houseHolderByFias.GetHouseHolderByFias();
                    break;
                case "GetAllHouseHolders":
                    AllHouseHolders allHouseHolders = new AllHouseHolders(request.@params);
                    result = await allHouseHolders.GetAllHouseHolders();
                    break;
            }
            return result;
        }

        [HttpPost]
        [Route("ReturnResponseDataAndSettings")]
        public async Task<ActionResult<ResponseDataAndSettings>> ReturnResponseDataAndSettings(GKH.Request request)
        {
            ResponseDataAndSettings result = new ResponseDataAndSettings();
            switch (request.MetodRequest)
            {
                case "GetCounterIndications":
                    CounterIndications accountInfo = new CounterIndications(request.@params);
                    result = await accountInfo.GetCounterIndications();
                    break;
            }
            return result;
        }

        [HttpPost]
        [Route("ReturnAccountResponseData")]
        public async Task<ActionResult<AccountResponseData>> ReturnAccountResponseData(GKH.Request request)
        {
            AccountResponseData result = new AccountResponseData();
            switch (request.MetodRequest)
            {
                case "AccountCounters":
                    AccountCounters accountInfo = new GKH.AccountCounters(request.@params);
                    result = await accountInfo.GetAccountCounters();
                    break;
            }
            return result;
        }

        [HttpPost]
        [Route("ReturnNoticeData")]
        public async Task<ActionResult<NoticeData>> ReturnNoticeData(GKH.Request request)
        {
            NoticeData result = new NoticeData();
            switch (request.MetodRequest)
            {
                case "FindTypeNotice":
                    FindTypeNotice findTypeNotice = new FindTypeNotice(request.@params);
                    result = await findTypeNotice.GetFindTypeNotice();
                    break;
            }
            return result;
        }

        [HttpPost]
        [Route("ReturnListPayLk")]
        public async Task<ActionResult<ListPayLk>> ReturnListPayLk(GKH.Request request)
        {
            ListPayLk result = new ListPayLk();
            switch (request.MetodRequest)
            {
                case "GetPaysLK":
                    PaysLK accountInfo = new PaysLK(request.@params);
                    result = await accountInfo.GetPaysLK();
                    break;
            }
            return result;
        }
    }
}
