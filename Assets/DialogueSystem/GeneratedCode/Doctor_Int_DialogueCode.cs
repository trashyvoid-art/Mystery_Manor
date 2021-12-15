using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Doctor_Int_DialogueCode : DialogueCode, IDialogueCode
    {
        public Doctor_Int_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: dad830d9-4c63-415e-bc73-4855505290b6 //
string name = "The Doctor";
Notes.Journal journal = Utility.Toolbox.Instance.Journal;


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_111235d5bb624d19946e762bf1a280be",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_111235d5bb624d19946e762bf1a280be);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_c40c75f7ca644e1583da2ba6315e5b36",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_c40c75f7ca644e1583da2ba6315e5b36);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_0bda6154d9ad4951aca73576e844976e",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_0bda6154d9ad4951aca73576e844976e);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_87f9875217284dc0b3c908f1ca13cbc7",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_87f9875217284dc0b3c908f1ca13cbc7);
            dialogueChecks.Add("Doctor_Int_34d216ed3e2441e2b55f70098edcf863_f1245363a5d24d94b2f2ea07cc6a9bff",Doctor_Int_34d216ed3e2441e2b55f70098edcf863_f1245363a5d24d94b2f2ea07cc6a9bff);
            dialogueChecks.Add("Doctor_Int_34d216ed3e2441e2b55f70098edcf863_7e1a168552cc460693010af8e013d287",Doctor_Int_34d216ed3e2441e2b55f70098edcf863_7e1a168552cc460693010af8e013d287);
            dialogueChecks.Add("Doctor_Int_34d216ed3e2441e2b55f70098edcf863_637132e8ba2c4fb2be88b02a3265195c",Doctor_Int_34d216ed3e2441e2b55f70098edcf863_637132e8ba2c4fb2be88b02a3265195c);
            eventFunctions.Add("Doctor_Int_5fbb3e8714954bc5a68e00794003104b",Doctor_Int_5fbb3e8714954bc5a68e00794003104b);
            dialogueChecks.Add("Doctor_Int_d09c729ef03f45e08acca62892397910_0370bcf77872489bbcb60121d1440ffa",Doctor_Int_d09c729ef03f45e08acca62892397910_0370bcf77872489bbcb60121d1440ffa);
            dialogueChecks.Add("Doctor_Int_d09c729ef03f45e08acca62892397910_2e9c4fb1a29d4f1aaf3b347eba4bc442",Doctor_Int_d09c729ef03f45e08acca62892397910_2e9c4fb1a29d4f1aaf3b347eba4bc442);
            dialogueChecks.Add("Doctor_Int_ffac6c857a84401fb9857b58847cd904_8abfeea0055449a9b61c2114e6751b51",Doctor_Int_ffac6c857a84401fb9857b58847cd904_8abfeea0055449a9b61c2114e6751b51);
            dialogueChecks.Add("Doctor_Int_ffac6c857a84401fb9857b58847cd904_96d8c9c9dbf04129afc52713af2e7b0e",Doctor_Int_ffac6c857a84401fb9857b58847cd904_96d8c9c9dbf04129afc52713af2e7b0e);
            dialogueChecks.Add("Doctor_Int_cc7a7cc56ff24b5ea54068729d3fdafb_f4407ebe73724d24afe3bdd2fda3361a",Doctor_Int_cc7a7cc56ff24b5ea54068729d3fdafb_f4407ebe73724d24afe3bdd2fda3361a);
            dialogueChecks.Add("Doctor_Int_cc7a7cc56ff24b5ea54068729d3fdafb_15e448712bb9441284918c899890d4ac",Doctor_Int_cc7a7cc56ff24b5ea54068729d3fdafb_15e448712bb9441284918c899890d4ac);
            dialogueChecks.Add("Doctor_Int_cc7a7cc56ff24b5ea54068729d3fdafb_206e262db23f47f4a51a74befb9d2fef",Doctor_Int_cc7a7cc56ff24b5ea54068729d3fdafb_206e262db23f47f4a51a74befb9d2fef);
            dialogueChecks.Add("Doctor_Int_5532e760463546f4b488351582b46058_c88f8ecb0e0449af8774a9e8a13cced6",Doctor_Int_5532e760463546f4b488351582b46058_c88f8ecb0e0449af8774a9e8a13cced6);
            dialogueChecks.Add("Doctor_Int_5532e760463546f4b488351582b46058_c00afbc9b00f4c6bb3fa298545980b32",Doctor_Int_5532e760463546f4b488351582b46058_c00afbc9b00f4c6bb3fa298545980b32);
            dialogueChecks.Add("Doctor_Int_c04e9e3893e64e3da14a0c1a90f54c95_a06e9a01feb6441581daf6dea281f307",Doctor_Int_c04e9e3893e64e3da14a0c1a90f54c95_a06e9a01feb6441581daf6dea281f307);
            dialogueChecks.Add("Doctor_Int_c04e9e3893e64e3da14a0c1a90f54c95_d92647e3ad2c4553a75372f939d43c0c",Doctor_Int_c04e9e3893e64e3da14a0c1a90f54c95_d92647e3ad2c4553a75372f939d43c0c);
            dialogueChecks.Add("Doctor_Int_8ec65d0bc28a4d72bcbe3cb56190601c_3b6d91b69ac442e4970bc294a16f5271",Doctor_Int_8ec65d0bc28a4d72bcbe3cb56190601c_3b6d91b69ac442e4970bc294a16f5271);
            dialogueChecks.Add("Doctor_Int_8ec65d0bc28a4d72bcbe3cb56190601c_8c02059317e94d10a3ada7bf9a849a2c",Doctor_Int_8ec65d0bc28a4d72bcbe3cb56190601c_8c02059317e94d10a3ada7bf9a849a2c);
            dialogueChecks.Add("Doctor_Int_aef544b5808f4b6c94445060f3cf4374_52de3c7c95f841a4bfa287a8f2d26967",Doctor_Int_aef544b5808f4b6c94445060f3cf4374_52de3c7c95f841a4bfa287a8f2d26967);
            dialogueChecks.Add("Doctor_Int_aef544b5808f4b6c94445060f3cf4374_f1ec2b50d2a64e76a7693df77f4f6af0",Doctor_Int_aef544b5808f4b6c94445060f3cf4374_f1ec2b50d2a64e76a7693df77f4f6af0);
            dialogueChecks.Add("Doctor_Int_25513dc3768e4453883cac36408c18d9_9ffeb0e12ef6430f806ccbe9d14c8dbc",Doctor_Int_25513dc3768e4453883cac36408c18d9_9ffeb0e12ef6430f806ccbe9d14c8dbc);
            dialogueChecks.Add("Doctor_Int_25513dc3768e4453883cac36408c18d9_267b6c04fec9404a876177eb853e2d93",Doctor_Int_25513dc3768e4453883cac36408c18d9_267b6c04fec9404a876177eb853e2d93);
            dialogueChecks.Add("Doctor_Int_0dce1df1b52945068f849d2df07e2d47_e73ea4e78f1a463c93fb49e5a80d4b79",Doctor_Int_0dce1df1b52945068f849d2df07e2d47_e73ea4e78f1a463c93fb49e5a80d4b79);
            dialogueChecks.Add("Doctor_Int_e1ab9f96dd7c4837977f58cca2ed471a_1b8ae4f57eb940db8255c3059199b15c",Doctor_Int_e1ab9f96dd7c4837977f58cca2ed471a_1b8ae4f57eb940db8255c3059199b15c);
            dialogueChecks.Add("Doctor_Int_e1ab9f96dd7c4837977f58cca2ed471a_7f859d06943a42c6a86d374ce5ab410a",Doctor_Int_e1ab9f96dd7c4837977f58cca2ed471a_7f859d06943a42c6a86d374ce5ab410a);
            dialogueChecks.Add("Doctor_Int_7ff2e7f4a7144bbeb28e215b8222869a_40da30bf259e4ff5996c46240d8b7783",Doctor_Int_7ff2e7f4a7144bbeb28e215b8222869a_40da30bf259e4ff5996c46240d8b7783);
            dialogueChecks.Add("Doctor_Int_7ff2e7f4a7144bbeb28e215b8222869a_d809e08552414250957d6932437b383e",Doctor_Int_7ff2e7f4a7144bbeb28e215b8222869a_d809e08552414250957d6932437b383e);
            dialogueChecks.Add("Doctor_Int_e843b6245edc47c08b787419caa4e012_e0de723eb1bf42ff94a2ba0467ecf18f",Doctor_Int_e843b6245edc47c08b787419caa4e012_e0de723eb1bf42ff94a2ba0467ecf18f);
            dialogueChecks.Add("Doctor_Int_6da77162a55043f997f4da595b8c477f_63abe42b2c1043fc8337d5e1f4d5c630",Doctor_Int_6da77162a55043f997f4da595b8c477f_63abe42b2c1043fc8337d5e1f4d5c630);
            eventFunctions.Add("Doctor_Int_5dc801571dcb4533a3c48b4da012660d",Doctor_Int_5dc801571dcb4533a3c48b4da012660d);
            eventFunctions.Add("Doctor_Int_877c44f565e04be1acd6878492155dea",Doctor_Int_877c44f565e04be1acd6878492155dea);
            dialogueChecks.Add("Doctor_Int_44e6714406f74d579f061c02c493ce08_62ee8ab7209a432dbfd6ba7220ff4a13",Doctor_Int_44e6714406f74d579f061c02c493ce08_62ee8ab7209a432dbfd6ba7220ff4a13);
            dialogueChecks.Add("Doctor_Int_44e6714406f74d579f061c02c493ce08_7945186dd5bd4f1ba560871cbdf3e563",Doctor_Int_44e6714406f74d579f061c02c493ce08_7945186dd5bd4f1ba560871cbdf3e563);
            dialogueChecks.Add("Doctor_Int_44e6714406f74d579f061c02c493ce08_1f3e1108eab243c98e6d87ceaebc1064",Doctor_Int_44e6714406f74d579f061c02c493ce08_1f3e1108eab243c98e6d87ceaebc1064);
            dialogueChecks.Add("Doctor_Int_1259550615ca4f678ad8d5ec0ca2e11c_37c3f44540414a98aab934d76f9ae725",Doctor_Int_1259550615ca4f678ad8d5ec0ca2e11c_37c3f44540414a98aab934d76f9ae725);
            dialogueChecks.Add("Doctor_Int_1259550615ca4f678ad8d5ec0ca2e11c_3bd65d619e004062b7a2aaf6c37a5ff0",Doctor_Int_1259550615ca4f678ad8d5ec0ca2e11c_3bd65d619e004062b7a2aaf6c37a5ff0);
            dialogueChecks.Add("Doctor_Int_515fadf0330242df8df362c15727b738_735a948b81de430298d6a9f25d181cb8",Doctor_Int_515fadf0330242df8df362c15727b738_735a948b81de430298d6a9f25d181cb8);
            dialogueChecks.Add("Doctor_Int_515fadf0330242df8df362c15727b738_72656494f0244566977ccb763f3083a9",Doctor_Int_515fadf0330242df8df362c15727b738_72656494f0244566977ccb763f3083a9);
            dialogueChecks.Add("Doctor_Int_5c8229355ecf48e28fa4c6ad2fd0ae67_aa2abab3ed09411e81bfda583cdb242c",Doctor_Int_5c8229355ecf48e28fa4c6ad2fd0ae67_aa2abab3ed09411e81bfda583cdb242c);
            dialogueChecks.Add("Doctor_Int_b268aa908c924eb5a0731b88cf2e7c7a_bacbe4092ede45f5b91a2769c775dd36",Doctor_Int_b268aa908c924eb5a0731b88cf2e7c7a_bacbe4092ede45f5b91a2769c775dd36);
            dialogueChecks.Add("Doctor_Int_903e9a4521d94854a641c65a21eaf393_afb37c004c3b423cb13dfa9d5dd6ce45",Doctor_Int_903e9a4521d94854a641c65a21eaf393_afb37c004c3b423cb13dfa9d5dd6ce45);
            dialogueChecks.Add("Doctor_Int_35344f9eb3514390b3b661b828cc2d9f_71e52410e69043cfa473c8f9f24807a2",Doctor_Int_35344f9eb3514390b3b661b828cc2d9f_71e52410e69043cfa473c8f9f24807a2);
            dialogueChecks.Add("Doctor_Int_fa58324d83b349799d5f7af30c01378e_0f98bff16e6a4b50837ee4a08862d205",Doctor_Int_fa58324d83b349799d5f7af30c01378e_0f98bff16e6a4b50837ee4a08862d205);
            dialogueChecks.Add("Doctor_Int_40a7933c4da044bb88e15bb0b189a461_0a7fdfa93062423c9c9ba1aef5ab2842",Doctor_Int_40a7933c4da044bb88e15bb0b189a461_0a7fdfa93062423c9c9ba1aef5ab2842);
            dialogueChecks.Add("Doctor_Int_2278a922b5f14cd59f45582410b84525_bb3ee7b6780e48e7a0a04e797fde3250",Doctor_Int_2278a922b5f14cd59f45582410b84525_bb3ee7b6780e48e7a0a04e797fde3250);
            dialogueChecks.Add("Doctor_Int_fae63bf8ceca4d9aa4606369217c3f02_7e1d471b4ae94a1bae5f4a2c84a921d1",Doctor_Int_fae63bf8ceca4d9aa4606369217c3f02_7e1d471b4ae94a1bae5f4a2c84a921d1);
            dialogueChecks.Add("Doctor_Int_32a5d767ddd64ac098cb8f807023af30_447f56cdc65d46fb934f42395b93dcdd",Doctor_Int_32a5d767ddd64ac098cb8f807023af30_447f56cdc65d46fb934f42395b93dcdd);
            dialogueChecks.Add("Doctor_Int_4c8c8347239b415ba9d9c6d7e135555d_b03f96c8b94e4f4ca05d54a8be9caad3",Doctor_Int_4c8c8347239b415ba9d9c6d7e135555d_b03f96c8b94e4f4ca05d54a8be9caad3);
            dialogueChecks.Add("Doctor_Int_077bbd2805654c1ab02e946afc518924_4737aa69eba340f2903404eefb42dc0d",Doctor_Int_077bbd2805654c1ab02e946afc518924_4737aa69eba340f2903404eefb42dc0d);
            dialogueChecks.Add("Doctor_Int_4756f178fc5744e796a598e7ab7c39df_32c43ba5cce449169535214773e342cf",Doctor_Int_4756f178fc5744e796a598e7ab7c39df_32c43ba5cce449169535214773e342cf);
            dialogueChecks.Add("Doctor_Int_36c07367dd194c16b9a5f90579246ba3_a9760e1730724e0bbdd4ceceb62453a0",Doctor_Int_36c07367dd194c16b9a5f90579246ba3_a9760e1730724e0bbdd4ceceb62453a0);
            dialogueChecks.Add("Doctor_Int_36c07367dd194c16b9a5f90579246ba3_4ae23e49173f4f978996d700968fc782",Doctor_Int_36c07367dd194c16b9a5f90579246ba3_4ae23e49173f4f978996d700968fc782);
            dialogueChecks.Add("Doctor_Int_63816d2ec13a4851b674ffe96593f864_0d40d9f30ec44070ad4e5003aee2a3b1",Doctor_Int_63816d2ec13a4851b674ffe96593f864_0d40d9f30ec44070ad4e5003aee2a3b1);
            dialogueChecks.Add("Doctor_Int_a6728619a21c43b69222366adbcef84f_aee5738f11f44a9e89598c9248af4dac",Doctor_Int_a6728619a21c43b69222366adbcef84f_aee5738f11f44a9e89598c9248af4dac);
            dialogueChecks.Add("Doctor_Int_a6728619a21c43b69222366adbcef84f_2b95eef89a7545f18f4ace11f8fd2d41",Doctor_Int_a6728619a21c43b69222366adbcef84f_2b95eef89a7545f18f4ace11f8fd2d41);
            dialogueChecks.Add("Doctor_Int_a6728619a21c43b69222366adbcef84f_06ecc81db7d747bcb9b6488e890187cc",Doctor_Int_a6728619a21c43b69222366adbcef84f_06ecc81db7d747bcb9b6488e890187cc);
            eventFunctions.Add("Doctor_Int_0eb957eb90a14f988ce3a45a7b19a437",Doctor_Int_0eb957eb90a14f988ce3a45a7b19a437);
            dialogueChecks.Add("Doctor_Int_f4507aee9145421d8039bd87db76f989_a2ee69ee402d4cb58bfacb041540265a",Doctor_Int_f4507aee9145421d8039bd87db76f989_a2ee69ee402d4cb58bfacb041540265a);
            dialogueChecks.Add("Doctor_Int_bb867fd2e5534301bbc01f05b041b108_df2a6fe5af2d4f3cb4c8d2412e5e7362",Doctor_Int_bb867fd2e5534301bbc01f05b041b108_df2a6fe5af2d4f3cb4c8d2412e5e7362);
            eventFunctions.Add("Doctor_Int_8aa844f3779a4feebc7646e2b5488105",Doctor_Int_8aa844f3779a4feebc7646e2b5488105);
            eventFunctions.Add("Doctor_Int_3b5375d974284aff8debba5b97a08630",Doctor_Int_3b5375d974284aff8debba5b97a08630);
            dialogueChecks.Add("Doctor_Int_5f905c28e344408eb8a56f1855eb53de_da0fab3505994780a3b74fe721d7035a",Doctor_Int_5f905c28e344408eb8a56f1855eb53de_da0fab3505994780a3b74fe721d7035a);
            eventFunctions.Add("Doctor_Int_b7ec5b4845db4235a9be2eb3cd912d4e",Doctor_Int_b7ec5b4845db4235a9be2eb3cd912d4e);
            eventFunctions.Add("Doctor_Int_e0ca023d9f084f8c99fd2d2c1939ca23",Doctor_Int_e0ca023d9f084f8c99fd2d2c1939ca23);
            eventFunctions.Add("Doctor_Int_009398ce2a8d45b2ad13bc7441cf9d4b",Doctor_Int_009398ce2a8d45b2ad13bc7441cf9d4b);
            dialogueChecks.Add("Doctor_Int_b07b8356afc64e5bacf848539447dc35_7e6c96fdbe9946bda1addc0b8324a177",Doctor_Int_b07b8356afc64e5bacf848539447dc35_7e6c96fdbe9946bda1addc0b8324a177);
            eventFunctions.Add("Doctor_Int_bf11f6c864ba485d9d0480f3ddb3206f",Doctor_Int_bf11f6c864ba485d9d0480f3ddb3206f);
            eventFunctions.Add("Doctor_Int_ec8a226256cb41559f7c9785804bee22",Doctor_Int_ec8a226256cb41559f7c9785804bee22);
            dialogueChecks.Add("Doctor_Int_59f1a7798a4c4c4ba717a12cf6e37d1f_b8e61effa7404e6d9a6710f2f24b22ff",Doctor_Int_59f1a7798a4c4c4ba717a12cf6e37d1f_b8e61effa7404e6d9a6710f2f24b22ff);
            eventFunctions.Add("Doctor_Int_cc41a09dfe6f4d7a8426b88f9ad56e55",Doctor_Int_cc41a09dfe6f4d7a8426b88f9ad56e55);
            eventFunctions.Add("Doctor_Int_997bc62ae0274e1a8d763f6e25738433",Doctor_Int_997bc62ae0274e1a8d763f6e25738433);
            eventFunctions.Add("Doctor_Int_696425df4c6b43c7b197120a0b5dc551",Doctor_Int_696425df4c6b43c7b197120a0b5dc551);
            dialogueChecks.Add("Doctor_Int_b10c92a59ea34f4e9a5375f243348e6d_220366a2d2b74314a719a6c33e1c591f",Doctor_Int_b10c92a59ea34f4e9a5375f243348e6d_220366a2d2b74314a719a6c33e1c591f);
            eventFunctions.Add("Doctor_Int_121acf017f1942ac88b7a026ed530f96",Doctor_Int_121acf017f1942ac88b7a026ed530f96);
            eventFunctions.Add("Doctor_Int_347c2f805b734ee6b2e5256d237f4a0d",Doctor_Int_347c2f805b734ee6b2e5256d237f4a0d);
            dialogueChecks.Add("Doctor_Int_cc1ed415a24e4b3595fe3ccd43d5f532_6bd40e9def04432298e88091bcae5d9b",Doctor_Int_cc1ed415a24e4b3595fe3ccd43d5f532_6bd40e9def04432298e88091bcae5d9b);
            eventFunctions.Add("Doctor_Int_61539658f6564a40ac7160e57ee180bf",Doctor_Int_61539658f6564a40ac7160e57ee180bf);
            eventFunctions.Add("Doctor_Int_b667dab0f8ac4623bd2ec13e2deb6d6a",Doctor_Int_b667dab0f8ac4623bd2ec13e2deb6d6a);
            eventFunctions.Add("Doctor_Int_b5126ca65fb943738bdeb56270e7e4b4",Doctor_Int_b5126ca65fb943738bdeb56270e7e4b4);
            eventFunctions.Add("Doctor_Int_ac8d37d7f96f48b6856d02cdea8db6c8",Doctor_Int_ac8d37d7f96f48b6856d02cdea8db6c8);
            eventFunctions.Add("Doctor_Int_d22a823328b74e0bb6e89ea96cc9901b",Doctor_Int_d22a823328b74e0bb6e89ea96cc9901b);
            eventFunctions.Add("Doctor_Int_36bf84278ccc4af68a30810afa48bbea",Doctor_Int_36bf84278ccc4af68a30810afa48bbea);
            eventFunctions.Add("Doctor_Int_d9974cb0bb1c47419c0d788dbce5aeb4",Doctor_Int_d9974cb0bb1c47419c0d788dbce5aeb4);
            eventFunctions.Add("Doctor_Int_b30cb6fcb2df481e8d1fc5669b1728a9",Doctor_Int_b30cb6fcb2df481e8d1fc5669b1728a9);
            eventFunctions.Add("Doctor_Int_d6dd1c6e7bad4ce782f7052760302621",Doctor_Int_d6dd1c6e7bad4ce782f7052760302621);
            eventFunctions.Add("Doctor_Int_6d4c7550700f4e1b874159117cb543bb",Doctor_Int_6d4c7550700f4e1b874159117cb543bb);
            eventFunctions.Add("Doctor_Int_77dbccd5dbee4c61af5888d69d8e3d60",Doctor_Int_77dbccd5dbee4c61af5888d69d8e3d60);
            eventFunctions.Add("Doctor_Int_fb7f571ad2214670a71ab52b14b4ab89",Doctor_Int_fb7f571ad2214670a71ab52b14b4ab89);
            eventFunctions.Add("Doctor_Int_5134b8d040a642829d6aa84591ff991a",Doctor_Int_5134b8d040a642829d6aa84591ff991a);
            eventFunctions.Add("Doctor_Int_8f8dc88012c640f4b98ba27980e05e07",Doctor_Int_8f8dc88012c640f4b98ba27980e05e07);
            dialogueChecks.Add("Doctor_Int_fd996c69e7f04e7ab45c0617429dcfb3_d510321839dd4b258b0a6c1cd99dadf4",Doctor_Int_fd996c69e7f04e7ab45c0617429dcfb3_d510321839dd4b258b0a6c1cd99dadf4);
            eventFunctions.Add("Doctor_Int_ad9f712fd1ad45b69cbdda709cda3340",Doctor_Int_ad9f712fd1ad45b69cbdda709cda3340);

        }

        // Dialogue Checks //
        // From Node: fd9ab04b-67a8-4b9c-a18d-70bcca6dad31 //
        // Choice: Where were you at the time of the murder? - 111235d5-bb62-4d19-946e-762bf1a280be //
        public bool Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_111235d5bb624d19946e762bf1a280be()
        {
            return (true);
        }
        // From Node: fd9ab04b-67a8-4b9c-a18d-70bcca6dad31 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - c40c75f7-ca64-4e15-83da-2ba6315e5b36 //
        public bool Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_c40c75f7ca644e1583da2ba6315e5b36()
        {
            return (true);
        }
        // From Node: fd9ab04b-67a8-4b9c-a18d-70bcca6dad31 //
        // Choice: Do you have any other information about the case? - 0bda6154-d9ad-4951-aca7-3576e844976e //
        public bool Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_0bda6154d9ad4951aca73576e844976e()
        {
            return (true);
        }
        // From Node: fd9ab04b-67a8-4b9c-a18d-70bcca6dad31 //
        // Choice: What do you know about the Adventurer's bloody nose? - 87f98752-1728-4dc0-b3c9-08f1ca13cbc7 //
        public bool Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_87f9875217284dc0b3c908f1ca13cbc7()
        {
            return (true);
        }
        // From Node: 34d216ed-3e24-41e2-b55f-70098edcf863 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - f1245363-a5d2-4d94-b2f2-ea07cc6a9bff //
        public bool Doctor_Int_34d216ed3e2441e2b55f70098edcf863_f1245363a5d24d94b2f2ea07cc6a9bff()
        {
            return (true);
        }
        // From Node: 34d216ed-3e24-41e2-b55f-70098edcf863 //
        // Choice: Do you have any other information about the case? - 7e1a1685-52cc-4606-9301-0af8e013d287 //
        public bool Doctor_Int_34d216ed3e2441e2b55f70098edcf863_7e1a168552cc460693010af8e013d287()
        {
            return (true);
        }
        // From Node: 34d216ed-3e24-41e2-b55f-70098edcf863 //
        // Choice: What do you know about the Adventurer's bloody nose? - 637132e8-ba2c-4fb2-be88-b02a3265195c //
        public bool Doctor_Int_34d216ed3e2441e2b55f70098edcf863_637132e8ba2c4fb2be88b02a3265195c()
        {
            return (true);
        }
        // From Node: d09c729e-f03f-45e0-8acc-a62892397910 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 0370bcf7-7872-489b-bcb6-0121d1440ffa //
        public bool Doctor_Int_d09c729ef03f45e08acca62892397910_0370bcf77872489bbcb60121d1440ffa()
        {
            return (true);
        }
        // From Node: d09c729e-f03f-45e0-8acc-a62892397910 //
        // Choice: What do you know about the Adventurer's bloody nose? - 2e9c4fb1-a29d-4f1a-af3b-347eba4bc442 //
        public bool Doctor_Int_d09c729ef03f45e08acca62892397910_2e9c4fb1a29d4f1aaf3b347eba4bc442()
        {
            return (true);
        }
        // From Node: ffac6c85-7a84-401f-b985-7b58847cd904 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 8abfeea0-0554-49a9-b61c-2114e6751b51 //
        public bool Doctor_Int_ffac6c857a84401fb9857b58847cd904_8abfeea0055449a9b61c2114e6751b51()
        {
            return (true);
        }
        // From Node: ffac6c85-7a84-401f-b985-7b58847cd904 //
        // Choice: Do you have any other information about the case? - 96d8c9c9-dbf0-4129-afc5-2713af2e7b0e //
        public bool Doctor_Int_ffac6c857a84401fb9857b58847cd904_96d8c9c9dbf04129afc52713af2e7b0e()
        {
            return (true);
        }
        // From Node: cc7a7cc5-6ff2-4b5e-a540-68729d3fdafb //
        // Choice: Where were you at the time of the murder? - f4407ebe-7372-4d24-afe3-bdd2fda3361a //
        public bool Doctor_Int_cc7a7cc56ff24b5ea54068729d3fdafb_f4407ebe73724d24afe3bdd2fda3361a()
        {
            return (true);
        }
        // From Node: cc7a7cc5-6ff2-4b5e-a540-68729d3fdafb //
        // Choice: Do you have any other information about the case? - 15e44871-2bb9-4412-8491-8c899890d4ac //
        public bool Doctor_Int_cc7a7cc56ff24b5ea54068729d3fdafb_15e448712bb9441284918c899890d4ac()
        {
            return (true);
        }
        // From Node: cc7a7cc5-6ff2-4b5e-a540-68729d3fdafb //
        // Choice: What do you know about the Adventurer's bloody nose? - 206e262d-b23f-47f4-a51a-74befb9d2fef //
        public bool Doctor_Int_cc7a7cc56ff24b5ea54068729d3fdafb_206e262db23f47f4a51a74befb9d2fef()
        {
            return (true);
        }
        // From Node: 5532e760-4635-46f4-b488-351582b46058 //
        // Choice: Do you have any other information about the case? - c88f8ecb-0e04-49af-8774-a9e8a13cced6 //
        public bool Doctor_Int_5532e760463546f4b488351582b46058_c88f8ecb0e0449af8774a9e8a13cced6()
        {
            return (true);
        }
        // From Node: 5532e760-4635-46f4-b488-351582b46058 //
        // Choice: What do you know about the Adventurer's bloody nose? - c00afbc9-b00f-4c6b-b3fa-298545980b32 //
        public bool Doctor_Int_5532e760463546f4b488351582b46058_c00afbc9b00f4c6bb3fa298545980b32()
        {
            return (true);
        }
        // From Node: c04e9e38-93e6-4e3d-a14a-0c1a90f54c95 //
        // Choice: Where were you at the time of the murder? - a06e9a01-feb6-4415-81da-f6dea281f307 //
        public bool Doctor_Int_c04e9e3893e64e3da14a0c1a90f54c95_a06e9a01feb6441581daf6dea281f307()
        {
            return (true);
        }
        // From Node: c04e9e38-93e6-4e3d-a14a-0c1a90f54c95 //
        // Choice: Do you have any other information about the case? - d92647e3-ad2c-4553-a753-72f939d43c0c //
        public bool Doctor_Int_c04e9e3893e64e3da14a0c1a90f54c95_d92647e3ad2c4553a75372f939d43c0c()
        {
            return (true);
        }
        // From Node: 8ec65d0b-c28a-4d72-bcbe-3cb56190601c //
        // Choice: Where were you at the time of the murder? - 3b6d91b6-9ac4-42e4-970b-c294a16f5271 //
        public bool Doctor_Int_8ec65d0bc28a4d72bcbe3cb56190601c_3b6d91b69ac442e4970bc294a16f5271()
        {
            return (true);
        }
        // From Node: 8ec65d0b-c28a-4d72-bcbe-3cb56190601c //
        // Choice: What do you know about the Adventurer's bloody nose? - 8c020593-17e9-4d10-a3ad-a7bf9a849a2c //
        public bool Doctor_Int_8ec65d0bc28a4d72bcbe3cb56190601c_8c02059317e94d10a3ada7bf9a849a2c()
        {
            return (true);
        }
        // From Node: aef544b5-808f-4b6c-9444-5060f3cf4374 //
        // Choice: Where were you at the time of the murder? - 52de3c7c-95f8-41a4-bfa2-87a8f2d26967 //
        public bool Doctor_Int_aef544b5808f4b6c94445060f3cf4374_52de3c7c95f841a4bfa287a8f2d26967()
        {
            return (true);
        }
        // From Node: aef544b5-808f-4b6c-9444-5060f3cf4374 //
        // Choice: Do you have any other information about the case? - f1ec2b50-d2a6-4e76-a769-3df77f4f6af0 //
        public bool Doctor_Int_aef544b5808f4b6c94445060f3cf4374_f1ec2b50d2a64e76a7693df77f4f6af0()
        {
            return (true);
        }
        // From Node: 25513dc3-768e-4453-883c-ac36408c18d9 //
        // Choice: Where were you at the time of the murder? - 9ffeb0e1-2ef6-430f-806c-cbe9d14c8dbc //
        public bool Doctor_Int_25513dc3768e4453883cac36408c18d9_9ffeb0e12ef6430f806ccbe9d14c8dbc()
        {
            return (true);
        }
        // From Node: 25513dc3-768e-4453-883c-ac36408c18d9 //
        // Choice: Do you have any other information about the case? - 267b6c04-fec9-404a-8761-77eb853e2d93 //
        public bool Doctor_Int_25513dc3768e4453883cac36408c18d9_267b6c04fec9404a876177eb853e2d93()
        {
            return (true);
        }
        // From Node: 0dce1df1-b529-4506-8f84-9d2df07e2d47 //
        // Choice: Where were you at the time of the murder? - e73ea4e7-8f1a-463c-93fb-49e5a80d4b79 //
        public bool Doctor_Int_0dce1df1b52945068f849d2df07e2d47_e73ea4e78f1a463c93fb49e5a80d4b79()
        {
            return (true);
        }
        // From Node: e1ab9f96-dd7c-4837-977f-58cca2ed471a //
        // Choice: Do you have any other information about the case? - 1b8ae4f5-7eb9-40db-8255-c3059199b15c //
        public bool Doctor_Int_e1ab9f96dd7c4837977f58cca2ed471a_1b8ae4f57eb940db8255c3059199b15c()
        {
            return (true);
        }
        // From Node: e1ab9f96-dd7c-4837-977f-58cca2ed471a //
        // Choice: What do you know about the Adventurer's bloody nose? - 7f859d06-943a-42c6-a86d-374ce5ab410a //
        public bool Doctor_Int_e1ab9f96dd7c4837977f58cca2ed471a_7f859d06943a42c6a86d374ce5ab410a()
        {
            return (true);
        }
        // From Node: 7ff2e7f4-a714-4bbe-b28e-215b8222869a //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 40da30bf-259e-4ff5-996c-46240d8b7783 //
        public bool Doctor_Int_7ff2e7f4a7144bbeb28e215b8222869a_40da30bf259e4ff5996c46240d8b7783()
        {
            return (true);
        }
        // From Node: 7ff2e7f4-a714-4bbe-b28e-215b8222869a //
        // Choice: Do you have any other information about the case? - d809e085-5241-4250-957d-6932437b383e //
        public bool Doctor_Int_7ff2e7f4a7144bbeb28e215b8222869a_d809e08552414250957d6932437b383e()
        {
            return (true);
        }
        // From Node: e843b624-5edc-47c0-8b78-7419caa4e012 //
        // Choice: Do you have any other information about the case? - e0de723e-b1bf-42ff-94a2-ba0467ecf18f //
        public bool Doctor_Int_e843b6245edc47c08b787419caa4e012_e0de723eb1bf42ff94a2ba0467ecf18f()
        {
            return (true);
        }
        // From Node: 6da77162-a550-43f9-97f4-da595b8c477f //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 63abe42b-2c10-43fc-8337-d5e1f4d5c630 //
        public bool Doctor_Int_6da77162a55043f997f4da595b8c477f_63abe42b2c1043fc8337d5e1f4d5c630()
        {
            return (true);
        }
        // From Node: 44e67144-06f7-4d57-9f06-1c02c493ce08 //
        // Choice:  Where were you at the time of the murder? - 62ee8ab7-209a-432d-bfd6-ba7220ff4a13 //
        public bool Doctor_Int_44e6714406f74d579f061c02c493ce08_62ee8ab7209a432dbfd6ba7220ff4a13()
        {
            return (true);
        }
        // From Node: 44e67144-06f7-4d57-9f06-1c02c493ce08 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 7945186d-d5bd-4f1b-a560-871cbdf3e563 //
        public bool Doctor_Int_44e6714406f74d579f061c02c493ce08_7945186dd5bd4f1ba560871cbdf3e563()
        {
            return (true);
        }
        // From Node: 44e67144-06f7-4d57-9f06-1c02c493ce08 //
        // Choice: What do you know about the Adventurer's bloody nose? - 1f3e1108-eab2-43c9-8e6d-87ceaebc1064 //
        public bool Doctor_Int_44e6714406f74d579f061c02c493ce08_1f3e1108eab243c98e6d87ceaebc1064()
        {
            return (true);
        }
        // From Node: 12595506-15ca-4f67-8ad8-d5ec0ca2e11c //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 37c3f445-4041-4a98-aab9-34d76f9ae725 //
        public bool Doctor_Int_1259550615ca4f678ad8d5ec0ca2e11c_37c3f44540414a98aab934d76f9ae725()
        {
            return (true);
        }
        // From Node: 12595506-15ca-4f67-8ad8-d5ec0ca2e11c //
        // Choice: What do you know about the Adventurer's bloody nose? - 3bd65d61-9e00-4062-b7a2-aaf6c37a5ff0 //
        public bool Doctor_Int_1259550615ca4f678ad8d5ec0ca2e11c_3bd65d619e004062b7a2aaf6c37a5ff0()
        {
            return (true);
        }
        // From Node: 515fadf0-3302-42df-8df3-62c15727b738 //
        // Choice: Where were you at the time of the murder? - 735a948b-81de-4302-98d6-a9f25d181cb8 //
        public bool Doctor_Int_515fadf0330242df8df362c15727b738_735a948b81de430298d6a9f25d181cb8()
        {
            return (true);
        }
        // From Node: 515fadf0-3302-42df-8df3-62c15727b738 //
        // Choice: What do you know about the Adventurer's bloody nose? - 72656494-f024-4566-977c-cb763f3083a9 //
        public bool Doctor_Int_515fadf0330242df8df362c15727b738_72656494f0244566977ccb763f3083a9()
        {
            return (true);
        }
        // From Node: 5c822935-5ecf-48e2-8fa4-c6ad2fd0ae67 //
        // Choice: What do you know about the Adventurer's bloody nose? - aa2abab3-ed09-411e-81bf-da583cdb242c //
        public bool Doctor_Int_5c8229355ecf48e28fa4c6ad2fd0ae67_aa2abab3ed09411e81bfda583cdb242c()
        {
            return (true);
        }
        // From Node: b268aa90-8c92-4eb5-a073-1b88cf2e7c7a //
        // Choice: Where were you at the time of the murder? - bacbe409-2ede-45f5-b91a-2769c775dd36 //
        public bool Doctor_Int_b268aa908c924eb5a0731b88cf2e7c7a_bacbe4092ede45f5b91a2769c775dd36()
        {
            return (true);
        }
        // From Node: 903e9a45-21d9-4854-a641-c65a21eaf393 //
        // Choice: Where were you at the time of the murder? - afb37c00-4c3b-423c-b13d-fa9d5dd6ce45 //
        public bool Doctor_Int_903e9a4521d94854a641c65a21eaf393_afb37c004c3b423cb13dfa9d5dd6ce45()
        {
            return (true);
        }
        // From Node: 35344f9e-b351-4390-b3b6-61b828cc2d9f //
        // Choice: Where were you at the time of the murder? - 71e52410-e690-43cf-a473-c8f9f24807a2 //
        public bool Doctor_Int_35344f9eb3514390b3b661b828cc2d9f_71e52410e69043cfa473c8f9f24807a2()
        {
            return (true);
        }
        // From Node: fa58324d-83b3-4979-9d5f-7af30c01378e //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 0f98bff1-6e6a-4b50-837e-e4a08862d205 //
        public bool Doctor_Int_fa58324d83b349799d5f7af30c01378e_0f98bff16e6a4b50837ee4a08862d205()
        {
            return (true);
        }
        // From Node: 40a7933c-4da0-44bb-88e1-5bb0b189a461 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 0a7fdfa9-3062-423c-9c9b-a1aef5ab2842 //
        public bool Doctor_Int_40a7933c4da044bb88e15bb0b189a461_0a7fdfa93062423c9c9ba1aef5ab2842()
        {
            return (true);
        }
        // From Node: 2278a922-b5f1-4cd5-9f45-582410b84525 //
        // Choice: What do you know about the Adventurer's bloody nose? - bb3ee7b6-780e-48e7-a0a0-4e797fde3250 //
        public bool Doctor_Int_2278a922b5f14cd59f45582410b84525_bb3ee7b6780e48e7a0a04e797fde3250()
        {
            return (true);
        }
        // From Node: fae63bf8-ceca-4d9a-a460-6369217c3f02 //
        // Choice: What do you know about the Adventurer's bloody nose? - 7e1d471b-4ae9-4a1b-ae5f-4a2c84a921d1 //
        public bool Doctor_Int_fae63bf8ceca4d9aa4606369217c3f02_7e1d471b4ae94a1bae5f4a2c84a921d1()
        {
            return (true);
        }
        // From Node: 32a5d767-ddd6-4ac0-98cb-8f807023af30 //
        // Choice: Do you have any other information about the case? - 447f56cd-c65d-46fb-934f-42395b93dcdd //
        public bool Doctor_Int_32a5d767ddd64ac098cb8f807023af30_447f56cdc65d46fb934f42395b93dcdd()
        {
            return (true);
        }
        // From Node: 4c8c8347-239b-415b-a9d9-c6d7e135555d //
        // Choice: Do you have any other information about the case? - b03f96c8-b94e-4f4c-a05d-54a8be9caad3 //
        public bool Doctor_Int_4c8c8347239b415ba9d9c6d7e135555d_b03f96c8b94e4f4ca05d54a8be9caad3()
        {
            return (true);
        }
        // From Node: 077bbd28-0565-4c1a-b02e-946afc518924 //
        // Choice: What do you know about the Adventurer's bloody nose? - 4737aa69-eba3-40f2-9034-04eefb42dc0d //
        public bool Doctor_Int_077bbd2805654c1ab02e946afc518924_4737aa69eba340f2903404eefb42dc0d()
        {
            return (true);
        }
        // From Node: 4756f178-fc57-44e7-96a5-98e7ab7c39df //
        // Choice: Do you have any other information about the case? - 32c43ba5-cce4-4916-9535-214773e342cf //
        public bool Doctor_Int_4756f178fc5744e796a598e7ab7c39df_32c43ba5cce449169535214773e342cf()
        {
            return (true);
        }
        // From Node: 36c07367-dd19-4c16-b9a5-f90579246ba3 //
        // Choice: Where were you at the time of the murder? - a9760e17-3072-4e0b-bdd4-ceceb62453a0 //
        public bool Doctor_Int_36c07367dd194c16b9a5f90579246ba3_a9760e1730724e0bbdd4ceceb62453a0()
        {
            return (true);
        }
        // From Node: 36c07367-dd19-4c16-b9a5-f90579246ba3 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 4ae23e49-173f-4f97-8996-d700968fc782 //
        public bool Doctor_Int_36c07367dd194c16b9a5f90579246ba3_4ae23e49173f4f978996d700968fc782()
        {
            return (true);
        }
        // From Node: 63816d2e-c13a-4851-b674-ffe96593f864 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 0d40d9f3-0ec4-4070-ad4e-5003aee2a3b1 //
        public bool Doctor_Int_63816d2ec13a4851b674ffe96593f864_0d40d9f30ec44070ad4e5003aee2a3b1()
        {
            return (true);
        }
        // From Node: a6728619-a21c-43b6-9222-366adbcef84f //
        // Choice: Where were you at the time of the murder? - aee5738f-11f4-4a9e-8959-8c9248af4dac //
        public bool Doctor_Int_a6728619a21c43b69222366adbcef84f_aee5738f11f44a9e89598c9248af4dac()
        {
            return (true);
        }
        // From Node: a6728619-a21c-43b6-9222-366adbcef84f //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 2b95eef8-9a75-45f1-8f4a-ce11f8fd2d41 //
        public bool Doctor_Int_a6728619a21c43b69222366adbcef84f_2b95eef89a7545f18f4ace11f8fd2d41()
        {
            return (true);
        }
        // From Node: a6728619-a21c-43b6-9222-366adbcef84f //
        // Choice: Do you have any other information about the case? - 06ecc81d-b7d7-47bc-b9b6-488e890187cc //
        public bool Doctor_Int_a6728619a21c43b69222366adbcef84f_06ecc81db7d747bcb9b6488e890187cc()
        {
            return (true);
        }
        // From Node: f4507aee-9145-421d-8039-bd87db76f989 //
        // Choice: Where were you at the time of the murder? - a2ee69ee-402d-4cb5-8bfa-cb041540265a //
        public bool Doctor_Int_f4507aee9145421d8039bd87db76f989_a2ee69ee402d4cb58bfacb041540265a()
        {
            return (true);
        }
        // From Node: bb867fd2-e553-4301-bbc0-1f05b041b108 //
        // Choice: What do you know about the Adventurer's bloody nose? - df2a6fe5-af2d-4f3c-b4c8-d2412e5e7362 //
        public bool Doctor_Int_bb867fd2e5534301bbc01f05b041b108_df2a6fe5af2d4f3cb4c8d2412e5e7362()
        {
            return (true);
        }
        // From Node: 5f905c28-e344-408e-b8a5-6f1855eb53de //
        // Choice: Where were you at the time of the murder? - da0fab35-0599-4780-a3b7-4fe721d7035a //
        public bool Doctor_Int_5f905c28e344408eb8a56f1855eb53de_da0fab3505994780a3b74fe721d7035a()
        {
            return (true);
        }
        // From Node: b07b8356-afc6-4e5b-acf8-48539447dc35 //
        // Choice: What do you know about the Adventurer's bloody nose? - 7e6c96fd-be99-46bd-a1ad-dc0b8324a177 //
        public bool Doctor_Int_b07b8356afc64e5bacf848539447dc35_7e6c96fdbe9946bda1addc0b8324a177()
        {
            return (true);
        }
        // From Node: 59f1a779-8a4c-4c4b-a717-a12cf6e37d1f //
        // Choice: Do you know why someone would have wanted to hurt the victim? - b8e61eff-a740-4e6d-9a67-10f2f24b22ff //
        public bool Doctor_Int_59f1a7798a4c4c4ba717a12cf6e37d1f_b8e61effa7404e6d9a6710f2f24b22ff()
        {
            return (true);
        }
        // From Node: b10c92a5-9ea3-4f4e-9a53-75f243348e6d //
        // Choice: Do you have any other information about the case? - 220366a2-d2b7-4314-a719-a6c33e1c591f //
        public bool Doctor_Int_b10c92a59ea34f4e9a5375f243348e6d_220366a2d2b74314a719a6c33e1c591f()
        {
            return (true);
        }
        // From Node: cc1ed415-a24e-4b35-95fe-3ccd43d5f532 //
        // Choice: Do you have any other information about the case? - 6bd40e9d-ef04-4322-98e8-8091bcae5d9b //
        public bool Doctor_Int_cc1ed415a24e4b3595fe3ccd43d5f532_6bd40e9def04432298e88091bcae5d9b()
        {
            return (true);
        }
        // From Node: fd996c69-e7f0-4e7a-b45c-0617429dcfb3 //
        // Choice: Do you have any other information about the case? - d5103218-39dd-4b25-8b0a-6c1cd99dadf4 //
        public bool Doctor_Int_fd996c69e7f04e7ab45c0617429dcfb3_d510321839dd4b258b0a6c1cd99dadf4()
        {
            return (true);
        }


        // Condition Checks //


        // Event Functions //
        // Event From Node: 5fbb3e87-1495-4bc5-a68e-00794003104b //
        public void Doctor_Int_5fbb3e8714954bc5a68e00794003104b() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: 5dc80157-1dcb-4533-a3c4-8b4da012660d //
        public void Doctor_Int_5dc801571dcb4533a3c48b4da012660d() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: 877c44f5-65e0-4be1-acd6-878492155dea //
        public void Doctor_Int_877c44f565e04be1acd6878492155dea() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }
        // Event From Node: 0eb957eb-90a1-4f98-8ce3-a45a7b19a437 //
        public void Doctor_Int_0eb957eb90a14f988ce3a45a7b19a437() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }
        // Event From Node: 8aa844f3-779a-4fee-bc76-46e2b5488105 //
        public void Doctor_Int_8aa844f3779a4feebc7646e2b5488105() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: 3b5375d9-7428-4aff-8deb-ba5b97a08630 //
        public void Doctor_Int_3b5375d974284aff8debba5b97a08630() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: b7ec5b48-45db-4235-a9be-2eb3cd912d4e //
        public void Doctor_Int_b7ec5b4845db4235a9be2eb3cd912d4e() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: e0ca023d-9f08-4f8c-99fd-2d2c1939ca23 //
        public void Doctor_Int_e0ca023d9f084f8c99fd2d2c1939ca23() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: 009398ce-2a8d-45b2-ad13-bc7441cf9d4b //
        public void Doctor_Int_009398ce2a8d45b2ad13bc7441cf9d4b() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: bf11f6c8-64ba-485d-9d04-80f3ddb3206f //
        public void Doctor_Int_bf11f6c864ba485d9d0480f3ddb3206f() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: ec8a2262-56cb-4155-9f7c-9785804bee22 //
        public void Doctor_Int_ec8a226256cb41559f7c9785804bee22() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: cc41a09d-fe6f-4d7a-8426-b88f9ad56e55 //
        public void Doctor_Int_cc41a09dfe6f4d7a8426b88f9ad56e55() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: 997bc62a-e027-4e1a-8d76-3f6e25738433 //
        public void Doctor_Int_997bc62ae0274e1a8d763f6e25738433() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: 696425df-4c6b-43c7-b197-120a0b5dc551 //
        public void Doctor_Int_696425df4c6b43c7b197120a0b5dc551() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: 121acf01-7f19-42ac-88b7-a026ed530f96 //
        public void Doctor_Int_121acf017f1942ac88b7a026ed530f96() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: 347c2f80-5b73-4ee6-b2e5-256d237f4a0d //
        public void Doctor_Int_347c2f805b734ee6b2e5256d237f4a0d() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: 61539658-f656-4a40-ac71-60e57ee180bf //
        public void Doctor_Int_61539658f6564a40ac7160e57ee180bf() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: b667dab0-f8ac-4623-bd2e-c13e2deb6d6a //
        public void Doctor_Int_b667dab0f8ac4623bd2ec13e2deb6d6a() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: b5126ca6-5fb9-4373-8bde-b56270e7e4b4 //
        public void Doctor_Int_b5126ca65fb943738bdeb56270e7e4b4() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }
        // Event From Node: ac8d37d7-f96f-48b6-856d-02cdea8db6c8 //
        public void Doctor_Int_ac8d37d7f96f48b6856d02cdea8db6c8() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }
        // Event From Node: d22a8233-28b7-4e0b-b6e8-9ea96cc9901b //
        public void Doctor_Int_d22a823328b74e0bb6e89ea96cc9901b() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }
        // Event From Node: 36bf8427-8ccc-4af6-8a30-810afa48bbea //
        public void Doctor_Int_36bf84278ccc4af68a30810afa48bbea() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }
        // Event From Node: d9974cb0-bb1c-4741-9c0d-788dbce5aeb4 //
        public void Doctor_Int_d9974cb0bb1c47419c0d788dbce5aeb4() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }
        // Event From Node: b30cb6fc-b2df-481e-8d1f-c5669b1728a9 //
        public void Doctor_Int_b30cb6fcb2df481e8d1fc5669b1728a9() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }
        // Event From Node: d6dd1c6e-7bad-4ce7-82f7-052760302621 //
        public void Doctor_Int_d6dd1c6e7bad4ce782f7052760302621() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }
        // Event From Node: 6d4c7550-700f-4e1b-8741-59117cb543bb //
        public void Doctor_Int_6d4c7550700f4e1b874159117cb543bb() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }
        // Event From Node: 77dbccd5-dbee-4c61-af58-88d69d8e3d60 //
        public void Doctor_Int_77dbccd5dbee4c61af5888d69d8e3d60() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }
        // Event From Node: fb7f571a-d221-4670-a71a-b52b14b4ab89 //
        public void Doctor_Int_fb7f571ad2214670a71ab52b14b4ab89() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }
        // Event From Node: 5134b8d0-40a6-4282-9d6a-a84591ff991a //
        public void Doctor_Int_5134b8d040a642829d6aa84591ff991a() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }
        // Event From Node: 8f8dc880-12c6-40f4-b98b-a27980e05e07 //
        public void Doctor_Int_8f8dc88012c640f4b98ba27980e05e07() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }
        // Event From Node: ad9f712f-d1ad-45b6-9cbd-da709cda3340 //
        public void Doctor_Int_ad9f712fd1ad45b69cbdda709cda3340() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }

    }
}
