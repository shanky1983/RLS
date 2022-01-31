Drop view  [View_TestDeptsInv67]


If Exists(Select 1 From Sys.sysobjects(nolock) Where TYPE = 'V'        And name = 'VW_TESTINFO')
               Begin
                       Drop VIEW VW_TESTINFO
               End