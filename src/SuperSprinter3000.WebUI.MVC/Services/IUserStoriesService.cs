﻿using SuperSprinter3000.WebUI.MVC.Models;

namespace SuperSprinter3000.WebUI.MVC.Services;

public interface IUserStoriesService
{
    public IEnumerable<UserStoryViewModel> GetAll();
    public EditUserStoryViewModel? GetByIdForEdit(int id);
    public void Add(AddUserStoryViewModel userStory);
    public void Update(int id, EditUserStoryViewModel userStory);
    public bool ExistsById(int id);
}