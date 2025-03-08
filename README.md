# 지금, 뭐 먹지?
### 2024 2학기 해달 해커톤 아이디어상 수상작🏆
아이디어톤: 2024. 11. 07 <br>
준비 기간: 2024. 11. 18 ~ 2024. 11. 22 <br>
행사 당일: 2024. 11. 23 <br>
<details>
  <summary> 상장 사본 </summary>
  <img src = "https://github.com/user-attachments/assets/7e9f4802-473d-4f21-a722-738d30d56b84", width = 350>
</details>

## Collaborator
### < Team 티모 >
* 박정원 (jjjung1)
* 김명진 (Myeongjini)
* 김명진 (Kim-myeongjin)
* 노성민 (RohSeongmin)
<details>
  <summary> 팀원별 개발 파트 </summary>
  
  <h3> 박정원 (jjjung1) [팀장] </h3>
  <li> 재료 합성 및 결과 출력 메커니즘 </li>
  <ul type = "circle">
    <li> 드래그 앤 드롭 합성 이벤트 구현 </li>
    <li> 재료 합성 단계의 확률형 결과 출력 코드 작성 </li>
    <li> 드래그 앤 드롭 시 Result Canvas 활성화 코드 </li>
    <li> Result Canvas의 UI 및 기능 시스템 제작 (합성 결과, 날짜 및 시간대 정보 등 출력) </li>
    <li> 결과창 이미지화 코드, SNS Sharing 기능 구현 (Native Share Plugin 활용) </li> 
  </ul>
  <li> 전체 코드 및 프로그램 검수 </li> 
  
  <h3> 김명진 (Myeongjini) </h3> 
  <li> 랜덤 재료 뽑기 시스템 구현 </li>
  <ul type = "circle">
    <li> Object Pool 생성 </li>
    <li> Pool에 속한 Object를 화면 상에 랜덤 배치 (랜덤한 종류, 랜덤한 위치) </li>
    <li> Object 배치 제한구역 설정 </li>
  </ul>
  <li> 메인화면 UI 전반 구성 </li> 
  <li> 미리캔버스, 생성형 AI를 이용한 에셋 디자인 </li> 
  <li> UI 디렉팅 </li> 

  <h3> 김명진 (Kim-myeongjin) </h3>
  <li> 화면 상의 재료 일괄 삭제 시스템 </li> 
  <li> 게임종료 함수 구현: Navigation Bar의 Back Button 두 번 터치 시 종료 </li> 
  <li> 시작화면 UI 구성 </li> 
  <li> OnClick으로 Canvas 터치 시 동작하는 Scene 전환 함수 구현 </li> 
  <li> 생성형 AI를 이용한 에셋 디자인 </li> 

  <h3> 노성민 (RohSeongmin) </h3>
  <li> OpenWeatherMap api를 이용한 날씨 시스템 구성 및 시간, 계절에 따른 Script 작성 </li> 
  <li> 메인 메뉴 작업 </li> 
   <ul type = "circle">
    <li> 주재료 선택 기능 구현 </li>
    <li> 랜덤 재료 선택 메커니즘 작성 </li>
    <li> 메인 메뉴 초기화 시스템 개발 </li>
  </ul>
</details>

## 앱 소개
현대인의 고민거리 1순위, ”오늘은 또 뭐 먹지?”

게임형 애플리케이션 <**지금, 뭐 먹지?**>가 해결해드릴게요.

밥인지, 빵인지, 면인지. 당신은 이것만 정하면 끝!

기본 주재료 밥, 빵, 면에 가챠(랜덤 뽑기)로 뽑은 4가지 부재료를 섞어서 오늘의 메뉴를 만들어봅시다.

먹음직한 나의 오늘 식사-

친구들에게 공유하는 것도 잊지 마세요!

## 전체 기능
<table>
  <tr><td>
    <img src="https://github.com/user-attachments/assets/e5bb5814-d2d6-4132-a947-efa6cf3faca5" width="200"><br>
    <p align="center"><1></p>
    <p align="center">시작 페이지</p>
  </td>
  <td">
  </td>
  <td>
    <img src="https://github.com/user-attachments/assets/1bb08060-fcd3-4c8c-b370-c9e03cebe7c0" width="300"><br>
    <p align="center"><2></p>
    <p align="center">메인 페이지</p>
  </td>
  <td>
   <img src="https://github.com/user-attachments/assets/4f9556da-70dd-4a0e-b4ce-27abc44a1a16" width="200"><br>
    <p align="center"><3></p>
    <p align="center">요리 주재료 선택</p>
  </td></tr>
  <tr><td>
   <img src="https://github.com/user-attachments/assets/cfc2a0b8-6144-40c4-a0f6-311e8915bfd9" width="200"><br>
    <p align="center"><4></p>
    <p align="center">요리 부재료 뽑기</p>
  </td>
  <td>
   <img src="https://github.com/user-attachments/assets/d3534b43-29d4-44a2-bf6f-d48dcba3915c" width="200"><br>
    <p align="center"><5></p>
    <p align="center">요리 합성 (확률형)</p>
  </td>
  <td>
    <img src="https://github.com/user-attachments/assets/b2fe3989-232d-4582-9c95-3142aedb53a8" width="200"><br>
    <p align="center"><번외></p>
    <p align="center">필드 위 재료 전체 삭제</p>
  </td></tr>
       <tr><td>
   <img src="https://github.com/user-attachments/assets/c4d857f8-32cd-4cdc-87f0-88eb070e9235" width="200"><br>
    <p align="center"><6></p>
    <p align="center">요리 합성 결과창</p>
  </td>
  <td>
   <img src="https://github.com/user-attachments/assets/33d9ae6a-1a80-4e6d-b1e8-d9e71d456ca2" width="200"><br>
    <p align="center"><7></p>
    <p align="center">나의 메뉴 SNS 공유</p>
  </td>
  <td>
   <img src="https://github.com/user-attachments/assets/0ed8abe5-efdf-4fff-b1f0-e0e382bf6d22" width="200"><br>
    <p align="center"><8 - 1></p>
    <p align="center">SNS 공유 - 문자</p>
  </td>
  <td>
    <img src="https://github.com/user-attachments/assets/f75f1bb1-e0fa-4bf4-a4f5-ef6e2a30b70c" width="200"><br>
    <p align="center"><8 - 2></p>
    <p align="center">SNS 공유 - 카카오톡</p>
  </td></tr>
</table>
      
## 시연 영상
(영상 링크)

## 안드로이드 다운로드
https://github.com/jjjung1/Today-s_Menu/releases/download/v1.0.1/Today_s_Menu.apk

## 설치 가이드
다운로드 링크로 apk 파일을 받아 모바일에서 설치해주세요! 
<table>
  <tr><td>
    <img src="https://github.com/user-attachments/assets/7fc28db1-960d-4ad0-a295-1e3195d5859e" width="200"><br>
    <p align="center"><1></p>
  </td>
  <td>
    <img src="https://github.com/user-attachments/assets/b622facd-52a4-4a17-a7b9-b9a5a7aee705" width="200"><br>
    <p align="center"><2></p>
  </td>
  <td>
    <img src="https://github.com/user-attachments/assets/d5d3e728-56f6-4ed2-845b-90846198b6b5" width="200"><br>
    <p align="center"><3></p>
  </td></tr>
  <tr><td>
    <img src="https://github.com/user-attachments/assets/673b53ee-f872-4d2e-bc55-1d98e200a701" width="200"><br>
    <p align="center"><4></p>
  </td>
  <td>
    <img src="https://github.com/user-attachments/assets/4a172b3e-200b-4ccc-bb9c-5b7a748cd6f7" width="200"><br>
    <p align="center"><5></p>
  </td>
  <td>
    <img src="https://github.com/user-attachments/assets/bdd380ee-0014-4dac-8c31-0bdb72428bf7" width="200"><br>
    <p align="center"><6></p>
  </td></tr>
</table>
