# Anaconda 자동실행 설정
    
-----------
      
## Batch 파일 설정
    set root=C:\Users\HP\miniconda3 
    //miniconda경로 설정
    call %root%\Scripts\activate.bat %root%

    call conda env list
    call conda activate 이름
    // 개인이 설정한 이름
    call cd ..
    // vtuber 폴더를 프로젝트와 같은 공간에 두었을 경우 
    call cd VTuber
    call python main.py

    pause
