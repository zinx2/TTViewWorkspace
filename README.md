# TTViewWorkspace
-피처(feature, 또는 토픽(topic)) 브랜치
 : 새로운 기능을 개발할 때마다 작업할 브랜치를 만드는데 이를 피처 브랜치라 함

- master와 branch는 별개로 운영됨
- 어느 쪽에서 프로젝트에 변경이 가해지더라도 서로에게 영향을 주지 않음
- branch는 merge를 위해서는 pull request를 통해 master에게 merge를 요청해야 함
- master는 이를 받아들여 branch와의 merge를 통해 프로젝트를 최신화하게 됨
- conflict가 발생하면 에러 메시지 발생
- conflict를 고치기 위해서는 conflict가 발생한 파일을 열어 파일을 수정해야 함
- branch에서 master로 파일 추가는 가능함

