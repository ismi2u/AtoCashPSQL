using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AtoCash.Data;
using AtoCash.Models;
using Microsoft.AspNetCore.Authorization;
using AtoCash.Authentication;

namespace AtoCash.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin, Finmgr")]
    public class DisbursementsAndClaimsMastersController : ControllerBase
    {
        private readonly AtoCashDbContext _context;

        public DisbursementsAndClaimsMastersController(AtoCashDbContext context)
        {
            _context = context;
        }

        // GET: api/DisbursementsAndClaimsMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DisbursementsAndClaimsMasterDTO>>> GetDisbursementsAndClaimsMasters()
        {
            List<DisbursementsAndClaimsMasterDTO> ListDisbursementsAndClaimsMasterDTO = new List<DisbursementsAndClaimsMasterDTO>();

            var disbursementsAndClaimsMasters = await _context.DisbursementsAndClaimsMasters.ToListAsync();

            foreach (DisbursementsAndClaimsMaster disbursementsAndClaimsMaster in disbursementsAndClaimsMasters)
            {
                DisbursementsAndClaimsMasterDTO disbursementsAndClaimsMasterDTO = new DisbursementsAndClaimsMasterDTO
                {
                    Id = disbursementsAndClaimsMaster.Id,
                    EmployeeId = disbursementsAndClaimsMaster.EmployeeId,
                    PettyCashRequestId = disbursementsAndClaimsMaster.PettyCashRequestId,
                    ExpenseReimburseReqId = disbursementsAndClaimsMaster.ExpenseReimburseReqId,
                    RequestTypeId = disbursementsAndClaimsMaster.RequestTypeId,
                    ProjectId = disbursementsAndClaimsMaster.ProjectId,
                    SubProjectId = disbursementsAndClaimsMaster.SubProjectId,
                    WorkTaskId = disbursementsAndClaimsMaster.WorkTaskId,
                    RecordDate = disbursementsAndClaimsMaster.RecordDate,
                    ClaimAmount = disbursementsAndClaimsMaster.ClaimAmount,
                    AmountToWallet = disbursementsAndClaimsMaster.AmountToWallet,
                    AmountToCredit = disbursementsAndClaimsMaster.AmountToCredit,
                    IsSettledAmountCredited = (disbursementsAndClaimsMaster.IsSettledAmountCredited ?? false) ?  true :false,
                    SettledDate = disbursementsAndClaimsMaster.SettledDate,
                    SettlementComment = disbursementsAndClaimsMaster.SettlementComment,
                    SettlementAccount = disbursementsAndClaimsMaster.SettlementAccount,
                    SettlementBankCard = disbursementsAndClaimsMaster.SettlementBankCard,
                    AdditionalData = disbursementsAndClaimsMaster.AdditionalData,
                    CostCenterId = disbursementsAndClaimsMaster.CostCenterId,
                    ApprovalStatusId = disbursementsAndClaimsMaster.ApprovalStatusId
                };

                ListDisbursementsAndClaimsMasterDTO.Add(disbursementsAndClaimsMasterDTO);

            }

            return ListDisbursementsAndClaimsMasterDTO;
        }

        // GET: api/DisbursementsAndClaimsMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DisbursementsAndClaimsMasterDTO>> GetDisbursementsAndClaimsMaster(int id)
        {


            var disbursementsAndClaimsMaster = await _context.DisbursementsAndClaimsMasters.FindAsync(id);

            if (disbursementsAndClaimsMaster == null)
            {
                return Conflict(new RespStatus { Status = "Failure", Message = "Disburese Id invalid!" });
            }

            DisbursementsAndClaimsMasterDTO disbursementsAndClaimsMasterDTO = new DisbursementsAndClaimsMasterDTO
            {
                Id = disbursementsAndClaimsMaster.Id,
                EmployeeId = disbursementsAndClaimsMaster.EmployeeId,
                PettyCashRequestId = disbursementsAndClaimsMaster.PettyCashRequestId,
                ExpenseReimburseReqId = disbursementsAndClaimsMaster.ExpenseReimburseReqId,
                RequestTypeId = disbursementsAndClaimsMaster.RequestTypeId,
                ProjectId = disbursementsAndClaimsMaster.ProjectId,
                SubProjectId = disbursementsAndClaimsMaster.SubProjectId,
                WorkTaskId = disbursementsAndClaimsMaster.WorkTaskId,
                RecordDate = disbursementsAndClaimsMaster.RecordDate,
                ClaimAmount = disbursementsAndClaimsMaster.ClaimAmount,
                AmountToWallet = disbursementsAndClaimsMaster.AmountToWallet,
                AmountToCredit = disbursementsAndClaimsMaster.AmountToCredit,
                IsSettledAmountCredited = (disbursementsAndClaimsMaster.IsSettledAmountCredited ?? false) ? true : false,
                SettledDate = disbursementsAndClaimsMaster.SettledDate,
                SettlementComment = disbursementsAndClaimsMaster.SettlementComment,
                SettlementAccount = disbursementsAndClaimsMaster.SettlementAccount,
                SettlementBankCard = disbursementsAndClaimsMaster.SettlementBankCard,
                AdditionalData = disbursementsAndClaimsMaster.AdditionalData,
                CostCenterId = disbursementsAndClaimsMaster.CostCenterId,
                ApprovalStatusId = disbursementsAndClaimsMaster.ApprovalStatusId
            };

            return disbursementsAndClaimsMasterDTO;
        }

        // PUT: api/DisbursementsAndClaimsMasters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDisbursementsAndClaimsMaster(int id, DisbursementsAndClaimsMasterDTO disbursementsAndClaimsMasterDto)
        {
            if (id != disbursementsAndClaimsMasterDto.Id)
            {
                return Conflict(new RespStatus { Status = "Failure", Message = "Id state is invalid" });
            }

            var disbursementsAndClaimsMaster = await _context.DisbursementsAndClaimsMasters.FindAsync(id);

            disbursementsAndClaimsMaster.EmployeeId = disbursementsAndClaimsMasterDto.EmployeeId;
            disbursementsAndClaimsMaster.PettyCashRequestId = disbursementsAndClaimsMasterDto.PettyCashRequestId;
            disbursementsAndClaimsMaster.ExpenseReimburseReqId = disbursementsAndClaimsMasterDto.ExpenseReimburseReqId;
            disbursementsAndClaimsMaster.RequestTypeId = disbursementsAndClaimsMasterDto.RequestTypeId;
            disbursementsAndClaimsMaster.ProjectId = disbursementsAndClaimsMasterDto.ProjectId;
            disbursementsAndClaimsMaster.SubProjectId = disbursementsAndClaimsMasterDto.SubProjectId;
            disbursementsAndClaimsMaster.WorkTaskId = disbursementsAndClaimsMasterDto.WorkTaskId;
            disbursementsAndClaimsMaster.RecordDate = disbursementsAndClaimsMasterDto.RecordDate;
            disbursementsAndClaimsMaster.AmountToWallet = disbursementsAndClaimsMasterDto.AmountToWallet;
            disbursementsAndClaimsMaster.AmountToCredit = disbursementsAndClaimsMasterDto.AmountToCredit;
            disbursementsAndClaimsMaster.IsSettledAmountCredited = disbursementsAndClaimsMasterDto.IsSettledAmountCredited;
            disbursementsAndClaimsMaster.SettledDate = disbursementsAndClaimsMasterDto.SettledDate;
            disbursementsAndClaimsMaster.SettlementComment = disbursementsAndClaimsMasterDto.SettlementComment;
            disbursementsAndClaimsMaster.SettlementAccount = disbursementsAndClaimsMasterDto.SettlementAccount;
            disbursementsAndClaimsMaster.SettlementBankCard = disbursementsAndClaimsMasterDto.SettlementBankCard;
            disbursementsAndClaimsMaster.AdditionalData = disbursementsAndClaimsMasterDto.AdditionalData;
            disbursementsAndClaimsMaster.CostCenterId = disbursementsAndClaimsMasterDto.CostCenterId;
            disbursementsAndClaimsMaster.ApprovalStatusId = disbursementsAndClaimsMasterDto.ApprovalStatusId;


            _context.DisbursementsAndClaimsMasters.Update(disbursementsAndClaimsMaster);
            //_context.Entry(disbursementsAndClaimsMasterDTO).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok(new RespStatus { Status = "Success", Message = "Disburse Details Updated!" });
        }

       

    }
}
