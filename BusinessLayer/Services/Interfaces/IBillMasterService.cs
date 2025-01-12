﻿using SmartBase.BusinessLayer.Core.Domain;
using SmartBase.BusinessLayer.Persistence;
using SmartBase.BusinessLayer.Persistence.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartBase.BusinessLayer.Services.Interfaces
{
    public interface IBillMasterService
    {
        Task<ServiceResponseModel<IEnumerable<BillMasterModel>>> GetAll(BillMasterModel getBillMasterModel);

         Task<PagedList<BillMaster>> GetAll(PageParams pageParams, BillMasterModel getBillMasterModel);

        Task<ServiceResponseModel<BillMasterModel>> GetBillId(BillMasterModel billMasterId);

        Task<ServiceResponseModel<BillMasterModel>> Add(BillMasterModel newBillMasterModel);

        Task<ServiceResponseModel<BillMasterModel>> Edit(BillMasterModel editBillMasterModel);

        Task<ServiceResponseModel<BillMasterModel>> Delete(BillMasterModel billMasterModel);
    }
}
