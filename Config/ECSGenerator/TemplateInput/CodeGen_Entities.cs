
    [StructLayout(LayoutKind.Sequential, Pack = Define.PackSize)]
    public unsafe partial struct __entities {
#_ME_FOR #RANGE(0,10,1)
        public const Int32 Size#FOR_ITEM = #FOR_ITEM;
#_ME_ENDFOR 

#_ME_FOR #ENTITY;use(#SIZE)
        public const Int32 #CLS_NAMESize = #SIZE;
    #_ME_FOR call GetEntityArray;rename(#TESTCLS_NAME = #CLS_NAME)
        public const #TESTCLS_NAME #CLS_NAME#FOR_ITEM;
    #_ME_ENDFOR 
#_ME_ENDFOR 

#_ME_FOR #ENTITY;use(#SIZE)
        public unsafe #CLS_NAME* Get#CLS_NAME(int index) {
            if (index >= 0 && index < #SIZE) {
                fixed (#CLS_NAME* p = &#CLS_NAME0) { 
                    return p + index; 
                }
            }
            NativeHelper.ArrayOutOfRange();
            return null;
        }
#_ME_ENDFOR 
    }