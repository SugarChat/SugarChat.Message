using SugarChat.Message.Common;

namespace SugarChat.Message.Exceptions
{
    public static class Prompt
    {
        #region User

        public static readonly ExceptionPrompt UserExists =
            new ExceptionPrompt(ExceptionCode.UserExists, "User with Id {0} already exists.");

        public static readonly ExceptionPrompt UserNoExists =
            new ExceptionPrompt(ExceptionCode.UserNoExists, "User with Id {0} dose not exist.");

        public static readonly ExceptionPrompt UpdateUserFailed =
            new ExceptionPrompt(ExceptionCode.UpdateUserFailed, "User with Id {0} updating failed.");

        public static readonly ExceptionPrompt AddUserFailed =
            new ExceptionPrompt(ExceptionCode.AddUserFailed, "User with Id {0} adding failed.");

        public static readonly ExceptionPrompt RemoveUserFailed =
            new ExceptionPrompt(ExceptionCode.RemoveUserFailed, "User with Id {0} removing failed.");

        public static readonly ExceptionPrompt NotAllUsersExists =
            new ExceptionPrompt(ExceptionCode.NotAllUsersExists, "Not all users exist.");

        #endregion

        #region Friend

        public static readonly ExceptionPrompt FriendAlreadyMade =
            new ExceptionPrompt(ExceptionCode.FriendAlreadyMade, "User with Id {0} has already made friend with Id {1}.");

        public static readonly ExceptionPrompt AddSelfAsFiend =
            new ExceptionPrompt(ExceptionCode.AddSelfAsFiend, "User with Id {0} should not add self as friend.");

        public static readonly ExceptionPrompt NotFriend =
            new ExceptionPrompt(ExceptionCode.NotFriend, "User with Id {0} has not been friend with Id {1} yet.");

        public static readonly ExceptionPrompt UpdateFriendFailed =
            new ExceptionPrompt(ExceptionCode.UpdateFriendFailed, "Friend with Id {0} updating failed.");

        public static readonly ExceptionPrompt AddFriendFailed =
            new ExceptionPrompt(ExceptionCode.AddFriendFailed, "Friend with Id {0} adding failed.");

        public static readonly ExceptionPrompt RemoveFriendFailed =
            new ExceptionPrompt(ExceptionCode.RemoveFriendFailed, "Friend with Id {0} removing failed.");

        #endregion

        #region Group

        public static readonly ExceptionPrompt GroupExists =
            new ExceptionPrompt(ExceptionCode.GroupExists, "Group with Id {0} already exists.");

        public static readonly ExceptionPrompt GroupNoExists =
            new ExceptionPrompt(ExceptionCode.GroupNoExists, "Group with Id {0} dose not exist.");

        public static readonly ExceptionPrompt NotInGroup =
            new ExceptionPrompt(ExceptionCode.NotInGroup, "User with Id {0} is not member of group with Id {1}.");

        public static readonly ExceptionPrompt GroupUserExists =
            new ExceptionPrompt(ExceptionCode.GroupUserExists, "User with Id {0} is already member of group with Id {1}.");

        public static readonly ExceptionPrompt NotAdmin =
            new ExceptionPrompt(ExceptionCode.NotAdmin, "User with Id {0} is not the administrator of group with Id {1}.");

        public static readonly ExceptionPrompt IsOwner =
            new ExceptionPrompt(ExceptionCode.IsOwner, "User with Id {0} is the owner of group with Id {1}.");

        public static readonly ExceptionPrompt IsNotOwner =
            new ExceptionPrompt(ExceptionCode.IsNotOwner, "User with Id {0} is not the owner of group with Id {1}.");

        public static readonly ExceptionPrompt UpdateGroupFailed =
            new ExceptionPrompt(ExceptionCode.UpdateGroupFailed, "Group with Id {0} updating failed.");

        public static readonly ExceptionPrompt AddGroupFailed =
            new ExceptionPrompt(ExceptionCode.AddGroupFailed, "Group with Id {0} adding failed.");

        public static readonly ExceptionPrompt RemoveGroupFailed =
            new ExceptionPrompt(ExceptionCode.RemoveGroupFailed, "Group with Id {0} removing failed.");

        #endregion

        #region Message

        public static readonly ExceptionPrompt MessageNoExists =
            new ExceptionPrompt(ExceptionCode.MessageNoExists, "Message with Id {0} dose not exist.");

        public static readonly ExceptionPrompt UpdateMessageFailed =
            new ExceptionPrompt(ExceptionCode.UpdateMessageFailed, "Message with Id {0} updating failed.");

        public static readonly ExceptionPrompt AddMessageFailed =
            new ExceptionPrompt(ExceptionCode.AddMessageFailed, "Message with Id {0} adding failed.");

        public static readonly ExceptionPrompt RemoveMessageFailed =
            new ExceptionPrompt(ExceptionCode.RemoveMessageFailed, "Message with Id {0} removing failed.");

        public static readonly ExceptionPrompt LastReadTimeLaterThan =
            new ExceptionPrompt(ExceptionCode.LastReadTimeLaterThan,
                "User with Id {0} from group with Id {1}'s Last Read Time is later than {2}.");
        
        public static readonly ExceptionPrompt RevokeOthersMessage =
            new ExceptionPrompt(ExceptionCode.RevokeOthersMessage,
                "User with Id {0} has no right to revoke message with Id {1} which it not sent by him.");
        
        public static readonly ExceptionPrompt TooLateToRevoke =
            new ExceptionPrompt(ExceptionCode.TooLateToRevoke,
                "User with Id {0} can not revoke message with Id {1} since it's sent quite a time ago.");

        #endregion

        #region GroupUser

        public static readonly ExceptionPrompt UpdateGroupUserFailed =
            new ExceptionPrompt(ExceptionCode.UpdateGroupUserFailed, "GroupUser with Id {0} updating failed.");

        public static readonly ExceptionPrompt AddGroupUserFailed =
            new ExceptionPrompt(ExceptionCode.AddGroupUserFailed, "GroupUser with Id {0} adding failed.");

        public static readonly ExceptionPrompt RemoveGroupUserFailed =
            new ExceptionPrompt(ExceptionCode.RemoveGroupUserFailed, "GroupUser with Id {0} removing failed.");

        public static readonly ExceptionPrompt AddGroupUsersFailed =
            new ExceptionPrompt(ExceptionCode.AddGroupUsersFailed, "Adding {0} groupUsers failed, only {1} of them added."); 
        
        public static readonly ExceptionPrompt UpdateGroupUsersFailed =
            new ExceptionPrompt(ExceptionCode.UpdateGroupUsersFailed, "Updating {0} groupUsers failed, only {1} of them updated.");

        public static readonly ExceptionPrompt RemoveGroupUsersFailed =
            new ExceptionPrompt(ExceptionCode.RemoveGroupUsersFailed, "Removing {0} groupUsers failed, only {1} of them removed.");

        public static readonly ExceptionPrompt NoCustomProperty =
            new ExceptionPrompt(ExceptionCode.NoCustomProperty, "There is no custom property provided.");
        
        public static readonly ExceptionPrompt SameGroupUser =
            new ExceptionPrompt(ExceptionCode.SameGroupUser, "Both GroupUsers have the same Id.");  
        
        public static readonly ExceptionPrompt SomeGroupUsersExist =
            new ExceptionPrompt(ExceptionCode.SomeGroupUsersExist, "Some of the groupUsers are already exist.");
        
        public static readonly ExceptionPrompt NotAllGroupUsersExist =
            new ExceptionPrompt(ExceptionCode.NotAllGroupUsersExist, "Not all of the groupUsers exist."); 
        
        public static readonly ExceptionPrompt RemoveOwnerFromGroup =
            new ExceptionPrompt(ExceptionCode.RemoveOwnerFromGroup, "It's not allowed to remove the owner from a group.");
        
        public static readonly ExceptionPrompt RemoveAdminByAdmin =
            new ExceptionPrompt(ExceptionCode.RemoveAdminByAdmin, "It's not allowed to remove an administrator by another.");
        
        public static readonly ExceptionPrompt SetGroupOwner =
            new ExceptionPrompt(ExceptionCode.SetGroupOwner, "It's not allowed to set an member as owner.");

        public static readonly ExceptionPrompt AddUsersToWrongGroup =
            new ExceptionPrompt(ExceptionCode.AddUsersToWrongGroup, "Should not add users to a different group.");

        #endregion

        #region Global

        public static readonly ExceptionPrompt IdIsNullOrEmpty =
            new ExceptionPrompt(ExceptionCode.IdIsNullOrEmpty, "Id should not be null or empty.");

        public static readonly ExceptionPrompt ParameterRequired = new ExceptionPrompt(ExceptionCode.ParameterRequired, "Parameter {0} is required.");
        #endregion
    }
}