# TTViewWorkspace

- COMMIT 주의 사항 :
 master에는 없는 파일을 branch에서 commit 하려 한다면 confict 발생하여 commit 실패함.

피처(feature, 또는 토픽(topic)) 브랜치 : 새로운 기능을 개발할 때마다 작업할 브랜치를 만드는데 이를 피처 브랜치라 한다.

고로, 이곳에서 작업하여 COMMIT.

master와 branch는 별개로 운영됨. 어느 쪽에서 프로젝트에 변경이 가해지더라도 서로에게 영향을 주지 않음.

branch는 merge를 위해서는 pull request를 통해 master에게 merge를 요청해야 하고, master는 이를 받아들여 branch와의 merge를 통해 프로젝트를 최신화하게 됨.



