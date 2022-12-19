# throwBallUnity
#丟球的小DEMO(使用VR的Oculus Quest 2)\
1.可以多人連線+語音\
2.可以抓取物品\
3.可使用teleport方法進移動\
4.嘴巴會隨著講話張開閉合 \
https://youtu.be/-UWVXgcy5ic

ref: 參考youtuber jack vr blockchain的影片製作

#專題<br>
2022/4/10更新<br>
https://youtu.be/D89rOGMxiUc<br>
已做:<br>
手部功能升級、移動功能升級、場景切換、註冊登入input、遊戲介紹影片。<br>

#開發流程<br>
-  開發前要先建立branch並checkout過去
```git
$git checkout -b {branch}
```
- 開發完成後檢查master是否有更新code，並rebase or merge
```git
$git fetch -p
$git rebase -i origin/master
```
- 解決衝突，在 Local 端試跑確定都可以通過
```git
$ git rebase --continue
$ git push -f origin/{branch}
```
