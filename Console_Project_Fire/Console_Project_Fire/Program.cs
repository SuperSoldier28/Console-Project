﻿using Console_Project_Fire;
using System;

class Program
{
    static void Main()
    {
        string[] Yeoju = File.ReadAllLines("StartBeautifulLLady.txt");

        for (int i = 0; i < Yeoju.Length; i++)
        {
            Console.WriteLine(Yeoju[i]);
        }
        // 사용자 이름 설정을 위해 초기화
        // 초기화 시켜놓지 않으면 밑에 if문에서 할당되지 않은 지역변수 name을 사용했다고 나옵니다.
        // 할당되지 않은 지역변수라는 오류를 보면 당황하지말고, 초기화를 시켜놓읍시다.
        string name = default;

        // 대사 저장한 Class Talking 생성자
        Talking talking = new Talking();

        // 해당 배열마다 대사를 뽑기 위한 변수 선언
        int Index = 0;

        // 게임 진행 중 어디서 나간지 확인하기 위한 변수 선언
        int gameOut = 0;


        // 미연시 사진과 같이 출력 될 시작 메세지
        Console.WriteLine("안녕하세요!");
        Console.WriteLine("망상의 나라 [찐따와 일진의 차이는 한 끝 차이라는 것을 여우에게 증명했던 건에 대하여]에 오신 것을 환영합니다.");
        Console.WriteLine("게임 진행을 위해 이름을 작성하고 Enter키를 2번 눌러주세요");
        Console.Write("이름 : ");
        name = Console.ReadLine();

        // 해당 배열마다 주인공 -> name으로 바꿔주기 위한 구문
        for (int i = 0; i < talking.Talk.Length; i++)
        {
            // 변경된 이름을 string 타입에 talking.Talk로 넣어줍니다.
            talking.Talk[i] = talking.Talk[i].Replace("주인공", name);
        }

        #region 남주 포효 이미지 
        void RenderKsw()
        {
            string[] ksw = File.ReadAllLines("ksw.txt");

            for (int i = 0; i < ksw.Length; i++)
            {
                Console.WriteLine(ksw[i]);
            }
        }
        #endregion

        #region 여주 우는 장면
        void RenderCrying()
        {
            string[] crying = File.ReadAllLines("crying.txt");

            for (int i = 0; i < crying.Length; i++)
            {
                Console.WriteLine(crying[i]);
            }
        }
        #endregion

        #region 히키코모리
        void RenderAlone()
        {
            string[] alone = File.ReadAllLines("alone.txt");

            for (int i = 0; i < alone.Length; i++)
            {
                Console.WriteLine(alone[i]);
            }
        }
        #endregion

        #region 맞는 장면
        void RenderViolence()
        {
            string[] violence = File.ReadAllLines("violence.txt");

            for (int i = 0; i < violence.Length; i++)
            {
                Console.WriteLine(violence[i]);
            }
        }
        #endregion

        #region 남주 진심 펀치
        void RenderPunch()
        {
            string[] punch = File.ReadAllLines("punch.txt");

            for (int i = 0; i < punch.Length; i++)
            {
                Console.WriteLine(punch[i]);
            }
        }
        #endregion

        #region 여주 울면서 고백
        void RenderHappyCrying()
        {
            string[] happyCrying = File.ReadAllLines("happyCrying.txt");

            for (int i = 0; i < happyCrying.Length; i++)
            {
                Console.WriteLine(happyCrying[i]);
            }
        }
        #endregion

        #region 남주 여주 결혼
        void RenderMarry()
        {
            string[] marry = File.ReadAllLines("marry.txt");

            for (int i = 0; i < marry.Length; i++)
            {
                Console.WriteLine(marry[i]);
            }
        }
        #endregion
        // 게임 루프
        while (true)
        {
            //==============Render================

            // 남주 포효 그려주기
            if (Index == 55) 
            {
                RenderKsw();
                ++Index;
            }

            // 남주 맞는 장면
            if (Index == 56)
            {
                RenderViolence();
                ++Index;
            }

            // 여주 울부짖는 장면
            if (Index == 57)
            {
                RenderCrying();
                ++Index;
            }

            // 남주 진심 펀치
            if (Index == 58)
            {
                RenderPunch();
                ++Index;
            }

            if (Index == 61)
            {
                RenderHappyCrying();
                ++Index;
            }




            //=============ProcessInput===========
            ConsoleKey key = ConsoleKey.NoName; // 콘솔 키 소환, 아무것도 아닌 상태

            if (Console.KeyAvailable == true) // 콘솔을 비동기로 만들어준다. 키를 눌렀을 때만 실행하도록 만들어준다.
            {
                key = Console.ReadKey().Key;
            }


            //=============Update=================

            // 게임 대사 및 나레이션
            if (key == ConsoleKey.Enter)
            {
                Console.WriteLine("============================================================================================================================================================");
                Console.WriteLine(" ");
                
                Console.WriteLine(talking.Talk[Index]);
                Index++;
                Console.WriteLine(" ");

                // 1번 선택지
                if (talking.Talk[Index] == "선택 1번")
                {
                    Console.WriteLine("1번 : 도와주러 간다");
                    Console.WriteLine("2번 : 도와주러 가지 않는다");
                    key = Console.ReadKey().Key;


                    if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
                    {
                        // [6] - 선택 1번 출력을 대사로 바꿔주기.
                        talking.Talk[Index] = talking.Talk[Index].Replace("선택 1번", "타다다닥!!!(뛰는 소리)\n주인공 : 저...저기요!!!");
                        continue;
                    }

                    if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                    {
                        gameOut = 1;
                        break;
                    }
                }

                // 2번 선택지
                if (talking.Talk[Index] == "선택 2번")
                {
                    Console.WriteLine("1번 : 김윤하한테 간다.");
                    Console.WriteLine("2번 : 김윤하한테 가지 않는다.");
                    key = Console.ReadKey().Key;


                    if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
                    {
                        // [6] - 선택 1번 출력을 대사로 바꿔주기.
                        talking.Talk[Index] = talking.Talk[Index].Replace("선택 2번", "터벅터벅\n주인공 : 어...어..!");
                        continue;
                    }

                    if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                    {
                        gameOut = 2;
                        break;
                    }
                }

                // 3번 선택지
                if (talking.Talk[Index] == "선택 3번")
                {
                    Console.WriteLine("1번 : 빵 사러 간다.");
                    Console.WriteLine("2번 : 빵 사러 가지 않는다.");
                    key = Console.ReadKey().Key;

                    if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
                    {
                        // [6] - 선택 1번 출력을 대사로 바꿔주기.
                        talking.Talk[Index] = talking.Talk[Index].Replace($"선택 3번", 
                            $"{name} : 어...어..! 빵은 어떤 걸로...?" +
                            "\n\n김윤하 : 아이 븅**끼야 너가 알아서 센스것 사와야지\n하나하나 가르쳐줘??" +
                            "\n\n주인공 : 어?! 아..아니야! 미안해! 얼른 사올게!!" +
                            "\n\n김윤하 : 3분 준다. 늦으면 1초당 로우킥이고 1분당 오토바이 태운다~^^" +
                            "\n\n주인공 : 얼른 다..다녀올게..!!!");
                        continue;
                    }

                    if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                    {
                        gameOut = 3;
                        break;
                    }
                }

                // 4번 선택지
                if (talking.Talk[Index] == "선택 4번")
                {
                    Console.WriteLine("1번 : 김윤하한테 간다.");
                    Console.WriteLine("2번 : 김윤하한테 가지 않는다.");
                    key = Console.ReadKey().Key;

                    if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                    {
                        // [6] - 선택 1번 출력을 대사로 바꿔주기.
                        talking.Talk[Index] = talking.Talk[Index].Replace("선택 4번",$"{name} : (두려움을 이겨내기 위해 몸을 떨면서) 싫어...싫다고...가지 않겠어...!");
                        continue;
                    }

                    if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
                    {
                        gameOut = 4;
                        break;
                    }
                }

                // 5번 선택지
                if (talking.Talk[Index] == "선택 5번")
                {
                    Console.WriteLine("다가오는 김윤하한테서!!!!!");
                    Console.WriteLine("\n1번 : 도망친다.");
                    Console.WriteLine("2번 : 도망치지 않고 맞선다.");
                    key = Console.ReadKey().Key;

                    if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                    {
                        // [6] - 선택 1번 출력을 대사로 바꿔주기.
                        talking.Talk[Index] = talking.Talk[Index].Replace("선택 5번", $"살면서 그 누구도 찐따였던 {name}을(를) 도와주지 않았다." +
                                                                                        "\n\n 하지만 서윤이는 달랐다. " +
                                                                                        "\n\n서윤이는 주인공을(를) 위해 달려왔고, 걱정 해줬고, 말리고 있었다." +
                                                                                         $"\n\n그런 서윤이에 모습에 감동을 받고, 용기를 얻은 {name}은(는) 두려움을 이긴 채 당당히 맞설려고 하고 있다!");
                        continue;
                    }

                    if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
                    {
                        gameOut = 5;
                        break;
                    }
                }

                // 6번 선택지
                if (talking.Talk[Index] == "선택 6번")
                {
                    Console.WriteLine("1번 : 김윤하한테 계속 맞는다.");
                    Console.WriteLine("2번 : 젖먹던 힘을 다해 김윤하를 때린다.");
                    key = Console.ReadKey().Key;

                    if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                    {
                       
                        talking.Talk[Index] = talking.Talk[Index].Replace("선택 6번", $"희미해진 정신 속 서윤이에 목소리를 들은 {name}은(는) 단전에 끓어오르는 분노와 서윤이에 애달픈 애원의 목소리에 온 힘을 다해!" +
                            $"\n\n{name} : (결연에 가득찬 목소리로) 김윤하!!!!!!!!!아아아아아악!!!!!!!!!!!!");
                        continue;
                    }

                    if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
                    {
                        gameOut = 6;
                        break;
                    }
                }

                // 7번 선택지
                if (talking.Talk[Index] == "선택 7번")
                {
                    Console.WriteLine("1번 : 턱");
                    Console.WriteLine("2번 : 볼");
                    key = Console.ReadKey().Key;


                    if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
                    {
                        talking.Talk[Index] = talking.Talk[Index].Replace("선택 7번", "털썩!!!!!(김윤하가 쓰러지는 소리)\n주인공 : 하아..하아..하아..!!");
                        continue;
                    }

                    if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                    {
                        gameOut = 7;
                        break;
                    }
                }

                // 8번 선택지
                if (talking.Talk[Index] == "선택 8번")
                {
                    Console.WriteLine("1번 : 사귄다.");
                    Console.WriteLine("2번 : 사귀지 않는다.");
                    key = Console.ReadKey().Key;


                    if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                    {
                        talking.Talk[Index] = talking.Talk[Index].Replace("선택 8번", "주인공 : (당황하면서)하하하...아니...우리 고3이잖아...프로그래밍 언어 공부에 집중하자...미안해 서윤아.");
                        continue;
                    }

                    if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                    {
                        gameOut = 8;
                        break;
                    }
                }


            }
        }

        // 주인공 이름 저장
        string heroName = name;
        ConsoleKey key1 = Console.ReadKey().Key;

        // 1번 선택지 게임 아웃
        if (gameOut == 1 && key1 == ConsoleKey.Enter)
        {
            Console.Clear();
            Console.WriteLine("iEu.  ,. ..  .  .                 .B. . ... ... . .   . .                                 .     .   ,7r:P:.             ... r,..,.,,,,::::i:::::iii;ri\r\n7uB,                               YM                                                                :i:7:                  ::       . ......,.:,:::::\r\nL78B  ,  .     .                    M5  . .                                                           ;rrL  :           ....,7....,.,.,,:,::::::::ii;:\r\n7YLMB. .                             @                                                                .r;J. i.          .. , r, .....,.,,:,:,::::i:ii:\r\ni;27EBi     ... . . .                :B                                                                :77v :               ,ri ......,.,.,,::::::::i:\r\ni:vU71Ov     .   .                    EU                                                               .;r7            ...   ,7  ....,.,.,.,,:::::::i:\r\nr:i7ULLNq:    .                        @,                                                               :rY.          ...     ;: .......,.,,:,::::::i:\r\ni:::rJJvjNY. .         .               :B                                                               .i5;                   r ........,.,,:,:::::::\r\nr:i:::vJY71XJ       , ,                 72                                                              .iUi        .:;v21k17:,i. ........,.,,:,::::i:\r\ni:ii::,ivY77XMr.       . .               Jv                                                              iL:    iLuSUuvri;7J2kSJ7  ......,.,.,,,,:::::\r\nr:i::::.,iLvrvZqi      ...                ji                                                             :q: .0BOJi::i7vYYuu2Uk0Mu  ......,.,,,,:::::,\r\ni:::::::..,rv7iLEU.    ....                r:                                                            ,1LG@Er:ruSPNPPSXk1XGqFFZ8i ......,.,.:,:::::\r\n;:i::::::...:rLrrJPL,                       ii                                                           rMBJ,:j8Pur:.. ..r,:iFBMS@O  ......,.,,:,:::,\r\ni:::::::,,....:r77iJ1r.                      ::                                                         X@7  UOS,           :i:78@BB  .......,.,,:,::,\r\n;,i::::,,,,.... :;vrrLU:    .                 .:                                                       B@..X@k,              .::.P@B  ........,,,,:::.\r\ni:::::::,,.,....  :77rrU7:                      ;:                                                    Z@.SBO.                  .  GB   ........,,,,::,\r\n;:i::::,,,,.,....   :r7;7JL     .                rU.                                                 L@.MBr                     .  50  .......,,,,:::.\r\ni:::::::,,.,......   .:vrr7ui                     .Fu.                                             .SB,qB,                          rJ ........,,,,::,\r\ni,i::::,:,,.,...... .  .i77;u2i   .                 .rr.                                          rXv:NBX                            ,L ....,.,,,,,,:.\r\ni:::::::,,,,..........   ,;7ir21.    .             .   r7                                       :jF.7OO@r                          ,  r7 ......,,,,::,\r\ni,i::::::,,.,...... ...    :rri7GL     .  .       .      ii   ...          .r .               rY:iYXBZZB:                           :  L: ....,.,,:,:.\r\ni:::::::,,,,........ . .     irr:kO:     ..          ,;jFqZG8OOO8MMMkuj. i81S:1:               kLNZGEEG@            .               ,.  r......,.:,::,\r\ni,:::::::,,.,........ .       ,;r:7MU            .JM@BBq2LLLuJuLLvjjuuS251PEOM@F               ,k0kkPPMB           :;               .i.  i....,.,,:::.\r\ni:::::::,,,,........ . . .      :7i:1P.   ..   LB@BS7r72NBBE1uLYjS0O@@B@BMOOZ8O@FiZ5. ..      :i,LNS1qG@          ,J                 .i  :: ...,,,,::,\r\ni:i::::::,,.,........ . . .      ,rr:rqL.    J@BSi;YEOOJi.          .:XB@OZqEqE8@vJkZ0E,7Nv   rBGuUJXPMB          Uj    .             .7  7i .,.,,:::.\r\ni::i::::,:,,.,...... ... .         iri:UP:  B@vi7PMN7,                  7@BOq00OM,   1v iMOO880kv;..rZ@@          U,:   .,             N   G:..,,,:::,\r\ni:i::::,:,,.,........ . . .   .     .;r:rF7BGiuSGPi                       OBPq8ZMLi: :vj8: uS7:.:ii:,:vJ.         j :J.               :.   iv ..,,:::,\r\ni::i::::,:,,.,.,........ . . .        :7i:kSYEkMF.                         0BS7r.  :7: .:.   :rr:..rri,7i        :u  k,             ..     Fi .,,:,::,\r\nr:i:::::::,,,.,............ .          .i:vJ8SMP.:.                         iUi:    :i.:ri777:.     ::ivL        L7..1.           .:.   :,1L..,,:,:,:,\r\ni:ii::::::,,.,........ . . .             :7Eq0BL::                            :7.    ..,  .,          :rF        ri..Z           ::   .: rL ...,,:::::\r\nr:iii::::::,,,,.,...... . . .            .LBBG@X:  .                            ..                    iivv       :7 F@          ::   .7 iJ:..,,,:::::,\r\nr:ii:i::::::,,.,.,..........             ,i5M@B@,.  .                             :vr.                irir       ,7 7. .       .:   ,7 i:r ..,,:,:::::\r\nr:;ii::::::,:,,,,........ . .            ,r,,vOBv:.  .                 ,            :0:               ,r;r,      ,i.          ,J   .: :Yi,..,.,,:::::,\r\nrii;ii::::::,:,,,,........ . . .         .r7:,.:YL.   .             .                ,j                irrv,     ;..         .k    ,  BG: .,,,,:,:::::\r\n7:;iiii::::::,:,,.,........ . . . .       .:;rr::Ni    .      .     :,,                :                r;rL    ;0          .S    :  2M. .,,,,:,::::i:\r\nri;;iiii::::::,:,,.,........ . . .           .,i:LBi                 0i. .:,           v.               :7ir7iiv1O          :    r   E:..,.,,:,:::::::\r\n7iri;ii:i::::::,,,,.,.......... . . .           i,MM                 F:,:ri:7:.       7r                 i7rrrv;iLi       ,     Nr  Y:..,.,,::::::::i:\r\n7irririiii::::::,:,,.......... . .     .        .i,@v               ., ..:7: .......,7J                  .:7rr:rr;7jj77jvSY,  .P@vvv...,.,,:,::::::ii:\r\nvirrriiii:i::::::,:.,............ . . .          :ii@:..           .,      ..   ,.  JJ;                     .  .r777vvYvYvvLJuNu7v7...,,,,:,::::::ii;:\r\n7r77;riiii:i::::::,:,,............ . . .          i:v@ :                    ..  .:   7                           .,::::::;rvvvii:,...,,:,:,::::::iiiii\r\nLr777rri;iiii::::::,:,,.,.,.......... .   .       .;:N5 .                            :.                                   ..,.  . ..,.,,::::::::i:iiri\r\nvr77r7rri;ii:i::::::,:,,.,.,........ . . . .       ,r:X  .,.                         O,                    . . .   .   . .    .....,,,,::::::::iiiii;i\r\nLrv77r7rri;iiii::::::::,,,,.............. . . .     :r7i  :i.                       kB                      .   . ... ............,.:,:,::::::i:iir;ri\r\nL77v77r7rri;iiii:i::::::,:.,.,............ . . .     irJ,   r:     ...       ....,rk1                  .   . . . ..............,.,,:,::::::::iiii;irri\r\nJ7Lvvr7r7;riiiiii::::::::,:.,.,.,.............. . .   rru:              ..,:iii:r7Lri                 . . . ... ............,.,,,,:::::::::iiiiir;rr7i\r\nYvvL7v77r7rr;;iiii:i::::::,:,,.,.............. ... .  .7r7ri.  ..::ir77LvLLLvLvv77r;.                . . . . ..............,.,.:,:,::::::i:iiii;;rr77r\r\njvYLLvv7777r7iririiii::::::::::,,,,.,.............. .  :L777LLUuYvL7v7777r7r7r7ri:.     . . . . . . . ... ..............,,,,,,:,::::::::iiii;ir;rr77vr\r\njLYYLYvL7777r7rr;ri;ii:i::::::::,:,:,,.,.,............ .:77vr77777rr;riiii:::,.      . . ..... ....................,.,.,,,,::::::::::iiii;irrrr7r77vv7\r\nU7Lvvvv77r7rri;iiii::::::::,,.,.......... .                .:,.                                                     . ........,.,,:,::::::i:ii;irrrrvr");
            Console.WriteLine($"\n\n{heroName}은(는) 무서워서 도망갔습니다.");
            Console.WriteLine($"그녀는 결국...나쁜 사람들 손에 다쳤고, {heroName}은(는) 방관죄로 감옥에 들어갔습니다.");
            Console.WriteLine("불의를 보면 참지 말고 싸우세요!");
        }

        // 2번 선택지 게임 아웃
        if (gameOut == 2 && key1 == ConsoleKey.Enter)
        {
            Console.Clear();
            Console.WriteLine($"{heroName}은(는) 괜한 객기로 김윤하의 화를 돋았습니다..");
            Console.WriteLine($"{heroName}은(는) 김윤하에게 이루 말하기 힘들정도로 구타를 당했습니다.");
            Console.WriteLine($"수치스러움을 느끼던 {heroName}은(는) 학교를 자퇴했습니다.");
        }

        // 3번 선택지 게임 아웃
        if (gameOut == 3 && key1 == ConsoleKey.Enter)
        {
            Console.Clear();
            Console.WriteLine($"{heroName}은(는) 빵을 사오지 않아 김윤하의 화를 돋았습니다.");
            Console.WriteLine($"{heroName}은(는) 김윤하에게 이루 말하기 힘들정도로 구타를 당했습니다.");
            Console.WriteLine($"수치스러움을 느끼던 {heroName}은(는) 학교를 자퇴했습니다.");
        }

        // 4번 선택지 게임 아웃
        if (gameOut == 4 && key1 == ConsoleKey.Enter)
        {
            Console.Clear();
            Console.WriteLine($"{heroName}은(는) 수치스럼울 무릎 쓰고 김윤하한테 걸어갔습니다.");
            Console.WriteLine($"{heroName}은(는) 서윤이가 보는 앞에서 싸대릴 여러대 맞고, 짓밟혔습니다.");
            Console.WriteLine($"서윤이가 보기가 부끄러웠던 {heroName}은(는) 학교를 자퇴했습니다.");
        }

        // 5번 선택지 게임 아웃
        if (gameOut == 5 && key1 == ConsoleKey.Enter)
        {
            Console.Clear();
            RenderAlone();
            Console.WriteLine($"\n\n{heroName}은(는) 두려움에 떤 채 도망치고 말았습니다.");
            Console.WriteLine($"\n{heroName}은(는) 서윤이가 보는 앞에서 바보처럼 도망친 자신을 자책하면서 방 밖으로 나오지 않았습니다.");
            Console.WriteLine($"\n그렇게 {heroName}은(는) 히키코모리가 되었습니다.");
        }

        // 6번 선택지 게임 아웃
        if (gameOut == 6 && key1 == ConsoleKey.Enter)
        {
            Console.Clear();
            RenderAlone();
            Console.WriteLine($"{heroName}은(는) 계속 맞다 결국 정신을 잃었습니다.");
            Console.WriteLine($"{heroName}은(는) 폭력에 대한 트라우마로인해 학굘르 나가지 못하고 병원 신세를 졌습니다.");
            Console.WriteLine($"{heroName}은(는) 그 누구와도 대화하지 못한채 히키코모리가 되었습니다.");
        }

        // 7번 선택지 게임 아웃
        if (gameOut == 7 && key1 == ConsoleKey.Enter)
        {
            Console.Clear();
            RenderAlone();
            Console.WriteLine($"\n{heroName}은(는) 볼을 때려 치명상을 주지 못했습니다.");
            Console.WriteLine($"\n체력이 이미 바닥난 {heroName}은(는) 더 이상 저항하지 못하고 계속 맞기만 했습니다. 너무 맞아 정신을 잃은 {heroName}은(는) 기절했습니다.");
            Console.WriteLine($"\n{heroName}은(는) 정신을 차린 뒤 폭력의 트라우마에서 벗아나지 못한채 히키코모리가 되었습니다.");
        }

        // 8번 선택지 게임 아웃
        if (gameOut == 8 && key1 == ConsoleKey.Enter)
        {
            Console.Clear();
            RenderMarry();
            Console.WriteLine($"\n{heroName}은(는) 꿈에 그리던 도내 최상 S급 미녀 서윤이와 연애를 했습니다.");
            Console.WriteLine($"\n그렇게 {heroName}과(와) 이서윤은 같은 대학으로 진학하고, 열심히 공부해서, 서로 진실된 사랑의 약속인 '결혼'을 하면서 서로 행복하게 살았답니다~~!!!");

        }

    }
}