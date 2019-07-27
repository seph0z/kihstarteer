using AutoMapper;
using CourseProject.Data.Contracts;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts;
using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseProject.Domain.Services
{
    public class RewardService : IRewardService
    {
        private readonly IRepository<Reward> repository;
        public RewardService(IRepository<Reward> repository)
        {
            this.repository = repository;
        }
        public void Add(RewardViewModel viewModel)
        {
            var reward = Mapper.Map<Reward>(viewModel);
            repository.Add(reward);
            repository.SaveChanges();
        }

        public void Delete(int rewardId)
        {
            repository.Remove(rewardId);
            repository.SaveChanges();
        }

        public RewardViewModel Get(int rewardId)
        {
            var reward = repository.Get(rewardId);
            var result = Mapper.Map<RewardViewModel>(reward);
            return result;
        }

        public IEnumerable<RewardViewModel> GetAll(int projectId)
        {
            var rewards = repository.GetAll().ToList().FindAll(x => x.ProjectId == projectId);
            var rewardViewModels = Mapper.Map<IEnumerable<Reward>, IEnumerable<RewardViewModel>>(rewards);
            return rewardViewModels;
        }

        public void Update(RewardViewModel viewModel)
        {
            var reward = Mapper.Map<Reward>(viewModel);
            repository.Update(reward);
            repository.SaveChanges();
        }
    }
}
