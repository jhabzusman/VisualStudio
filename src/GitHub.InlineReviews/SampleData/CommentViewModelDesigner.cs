﻿using System;
using System.Reactive;
using ReactiveUI;
using GitHub.InlineReviews.ViewModels;
using GitHub.Models;
using GitHub.SampleData;
using GitHub.ViewModels;

namespace GitHub.InlineReviews.SampleData
{
    class CommentViewModelDesigner : ViewModelBase, ICommentViewModel
    {
        public CommentViewModelDesigner()
        {
            User = new AccountDesigner { Login = "shana", IsUser = true };
        }

        public int Id { get; set; }
        public string Body { get; set; }
        public string ErrorMessage { get; set; }
        public CommentEditState EditState { get; set; }
        public DateTimeOffset UpdatedAt => DateTime.Now.Subtract(TimeSpan.FromDays(3));
        public IAccount User { get; set; }

        public ReactiveCommand<object> BeginEdit { get; }
        public ReactiveCommand<object> CancelEdit { get; }
        public ReactiveCommand<Unit> CommitEdit { get; }
    }
}
