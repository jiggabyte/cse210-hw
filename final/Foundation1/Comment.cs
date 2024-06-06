using System;
using System.Collections.Generic;

class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public void SetCommenterName(string commenterName)
    {
        _commenterName = commenterName;
    }

    public string GetCommentText()
    {
        return _commentText;
    }

    public void SetCommentText(string commentText)
    {
        _commentText = commentText;
    }


}