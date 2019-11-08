git filter-branch -f --env-filter '
an="$GIT_AUTHOR_NAME"
am="$GIT_AUTHOR_EMAIL"
cn="$GIT_COMMITTER_NAME"
cm="$GIT_COMMITTER_EMAIL"
if [ "$GIT_COMMITTER_EMAIL" = "user@qq.com" ]
then
    cn="Aenlly"
    cm="2645274834@qq.com"
fi
if [ "$GIT_AUTHOR_EMAIL" = "user@qq.com" ]
then
    an="Aenlly"
    am="2645274834@qq.com"
fi
    export GIT_AUTHOR_NAME="$an"
    export GIT_AUTHOR_EMAIL="$am"
    export GIT_COMMITTER_NAME="$cn"
    export GIT_COMMITTER_EMAIL="$cm"
'