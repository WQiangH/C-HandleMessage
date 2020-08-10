using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MHandleEventCenter
{
    private static Dictionary<MEvenType, Delegate> mEventGroup = new Dictionary<MEvenType, Delegate>();

    public static void AddListenerCommon(MEvenType mEvenType, Delegate mCallBack)
    {
        if (!mEventGroup.ContainsKey(mEvenType))
        {
            mEventGroup.Add(mEvenType, null);
        }
        Delegate temp_delegate = mEventGroup[mEvenType];
        if (temp_delegate != null && temp_delegate.GetType() != mCallBack.GetType())
        {
            throw new Exception(string.Format("注册监听器错误：事件类型{0}所需MCallback为{1}，增加的MCallBack为{2}，两者不一致", mEvenType, temp_delegate.GetType(), mCallBack.GetType()));
        }
    }

    //0 parameters AddListener
    public static void AddListener(MEvenType mEvenType, MCallBack mCallBack)
    {
        AddListenerCommon(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack)mEventGroup[mEvenType] + mCallBack;
    }

    //1 parameters AddListener
    public static void AddListener<T>(MEvenType mEvenType, MCallBack<T> mCallBack)
    {
        AddListenerCommon(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T>)mEventGroup[mEvenType] + mCallBack;
    }
    //2 parameters AddListener
    public static void AddListener<T, A>(MEvenType mEvenType, MCallBack<T, A> mCallBack)
    {
        AddListenerCommon(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A>)mEventGroup[mEvenType] + mCallBack;
    }
    //3 parameters AddListener
    public static void AddListener<T, A, B>(MEvenType mEvenType, MCallBack<T, A, B> mCallBack)
    {
        AddListenerCommon(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A, B>)mEventGroup[mEvenType] + mCallBack;
    }
    //4 parameters AddListener
    public static void AddListener<T, A, B, C>(MEvenType mEvenType, MCallBack<T, A, B, C> mCallBack)
    {
        AddListenerCommon(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A, B, C>)mEventGroup[mEvenType] + mCallBack;
    }
    //5 parameters AddListener
    public static void AddListener<T, A, B, C, D>(MEvenType mEvenType, MCallBack<T, A, B, C, D> mCallBack)
    {
        AddListenerCommon(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A, B, C, D>)mEventGroup[mEvenType] + mCallBack;
    }
    //6 parameters AddListener
    public static void AddListener<T, A, B, C, D, E>(MEvenType mEvenType, MCallBack<T, A, B, C, D, E> mCallBack)
    {
        AddListenerCommon(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A, B, C, D, E>)mEventGroup[mEvenType] + mCallBack;
    }
    //7 parameters AddListener
    public static void AddListener<T, A, B, C, D, E, F>(MEvenType mEvenType, MCallBack<T, A, B, C, D, E, F> mCallBack)
    {
        AddListenerCommon(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A, B, C, D, E, F>)mEventGroup[mEvenType] + mCallBack;
    }
    //8 parameters AddListener
    public static void AddListener<T, A, B, C, D, E, F, G>(MEvenType mEvenType, MCallBack<T, A, B, C, D, E, F, G> mCallBack)
    {
        AddListenerCommon(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A, B, C, D, E, F, G>)mEventGroup[mEvenType] + mCallBack;
    }
    //9 parameters AddListener
    public static void AddListener<T, A, B, C, D, E, F, G, H>(MEvenType mEvenType, MCallBack<T, A, B, C, D, E, F, G, H> mCallBack)
    {
        AddListenerCommon(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A, B, C, D, E, F, G, H>)mEventGroup[mEvenType] + mCallBack;
    }


    public static void RemoveListenerCommon1(MEvenType mEvenType, Delegate mCallBack)
    {
        if (mEventGroup.ContainsKey(mEvenType))
        {
            Delegate temp_delegate = mEventGroup[mEvenType];
            if (null == temp_delegate)
            {
                throw new Exception(string.Format("移除监听器错误：事件类型{0}没有对应MCallBack", mEvenType));
            }
            else if (temp_delegate.GetType() != mCallBack.GetType())
            {
                throw new Exception(string.Format("移除监听器错误：事件类型{0}当前的MCallback为{1}，要移除的MCallBack为{2}，两者不一致", mEvenType, temp_delegate.GetType(), mCallBack.GetType()));
            }
        }
        else
        {
            throw new Exception(string.Format("移除监听器错误：不存在事件类型{0}", mEvenType));
        }
    }

    public static void RemoveListenerCommon2(MEvenType mEvenType)
    {
        if (null == mEventGroup[mEvenType])
        {
            mEventGroup.Remove(mEvenType);
        }
    }

    //0 parameters RemoveListener
    public static void RemoveListener(MEvenType mEvenType, MCallBack mCallBack)
    {
        RemoveListenerCommon1(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack)mEventGroup[mEvenType] - mCallBack;
        RemoveListenerCommon2(mEvenType);
    }

    //1 parameters RemoveListener
    public static void RemoveListener<T>(MEvenType mEvenType, MCallBack<T> mCallBack)
    {
        RemoveListenerCommon1(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T>)mEventGroup[mEvenType] - mCallBack;
        RemoveListenerCommon2(mEvenType);
    }

    //2 parameters RemoveListener
    public static void RemoveListener<T, A>(MEvenType mEvenType, MCallBack<T, A> mCallBack)
    {
        RemoveListenerCommon1(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A>)mEventGroup[mEvenType] - mCallBack;
        RemoveListenerCommon2(mEvenType);
    }

    //3 parameters RemoveListener
    public static void RemoveListener<T, A, B>(MEvenType mEvenType, MCallBack<T, A, B> mCallBack)
    {
        RemoveListenerCommon1(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A, B>)mEventGroup[mEvenType] - mCallBack;
        RemoveListenerCommon2(mEvenType);
    }

    //4 parameters RemoveListener
    public static void RemoveListener<T, A, B, C>(MEvenType mEvenType, MCallBack<T, A, B, C> mCallBack)
    {
        RemoveListenerCommon1(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A, B, C>)mEventGroup[mEvenType] - mCallBack;
        RemoveListenerCommon2(mEvenType);
    }

    //5 parameters RemoveListener
    public static void RemoveListener<T, A, B, C, D>(MEvenType mEvenType, MCallBack<T, A, B, C, D> mCallBack)
    {
        RemoveListenerCommon1(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A, B, C, D>)mEventGroup[mEvenType] - mCallBack;
        RemoveListenerCommon2(mEvenType);
    }

    //6 parameters RemoveListener
    public static void RemoveListener<T, A, B, C, D, E>(MEvenType mEvenType, MCallBack<T, A, B, C, D, E> mCallBack)
    {
        RemoveListenerCommon1(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A, B, C, D, E>)mEventGroup[mEvenType] - mCallBack;
        RemoveListenerCommon2(mEvenType);
    }

    //7 parameters RemoveListener
    public static void RemoveListener<T, A, B, C, D, E, F>(MEvenType mEvenType, MCallBack<T, A, B, C, D, E, F> mCallBack)
    {
        RemoveListenerCommon1(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A, B, C, D, E, F>)mEventGroup[mEvenType] - mCallBack;
        RemoveListenerCommon2(mEvenType);
    }

    //8 parameters RemoveListener
    public static void RemoveListener<T, A, B, C, D, E, F, G>(MEvenType mEvenType, MCallBack<T, A, B, C, D, E, F, G> mCallBack)
    {
        RemoveListenerCommon1(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A, B, C, D, E, F, G>)mEventGroup[mEvenType] - mCallBack;
        RemoveListenerCommon2(mEvenType);
    }

    //9 parameters RemoveListener
    public static void RemoveListener<T, A, B, C, D, E, F, G, H>(MEvenType mEvenType, MCallBack<T, A, B, C, D, E, F, G, H> mCallBack)
    {
        RemoveListenerCommon1(mEvenType, mCallBack);
        mEventGroup[mEvenType] = (MCallBack<T, A, B, C, D, E, F, G, H>)mEventGroup[mEvenType] - mCallBack;
        RemoveListenerCommon2(mEvenType);
    }



    //0 parameters Broadcast
    public static void Broadcast(MEvenType mEvenType)
    {
        Delegate temp_delegate;
        if (mEventGroup.TryGetValue(mEvenType, out temp_delegate))
        {
            MCallBack mCallBack = temp_delegate as MCallBack;
            if (mCallBack != null)
            {
                mCallBack();
            }
            else
            {
                throw new Exception(string.Format("广播事件错误：事件类型{0}对应的MCallBack具有不同的类型", mEvenType));
            }
        }
    }

    //1 parameters Broadcast
    public static void Broadcast<T>(MEvenType mEvenType, T arg)
    {
        Delegate temp_delegate;
        if (mEventGroup.TryGetValue(mEvenType, out temp_delegate))
        {
            MCallBack<T> mCallBack = temp_delegate as MCallBack<T>;
            if (mCallBack != null)
            {
                mCallBack(arg);
            }
            else
            {
                throw new Exception(string.Format("广播事件错误：事件类型{0}对应的MCallBack具有不同的类型", mEvenType));
            }
        }
    }

    //2 parameters Broadcast
    public static void Broadcast<T, A>(MEvenType mEvenType, T arg1, A arg2)
    {
        Delegate temp_delegate;
        if (mEventGroup.TryGetValue(mEvenType, out temp_delegate))
        {
            MCallBack<T, A> mCallBack = temp_delegate as MCallBack<T, A>;
            if (mCallBack != null)
            {
                mCallBack(arg1, arg2);
            }
            else
            {
                throw new Exception(string.Format("广播事件错误：事件类型{0}对应的MCallBack具有不同的类型", mEvenType));
            }
        }
    }

    //3 parameters Broadcast
    public static void Broadcast<T, A, B>(MEvenType mEvenType, T arg1, A arg2, B arg3)
    {
        Delegate temp_delegate;
        if (mEventGroup.TryGetValue(mEvenType, out temp_delegate))
        {
            MCallBack<T, A, B> mCallBack = temp_delegate as MCallBack<T, A, B>;
            if (mCallBack != null)
            {
                mCallBack(arg1, arg2, arg3);
            }
            else
            {
                throw new Exception(string.Format("广播事件错误：事件类型{0}对应的MCallBack具有不同的类型", mEvenType));
            }
        }
    }

    //4 parameters Broadcast
    public static void Broadcast<T, A, B, C>(MEvenType mEvenType, T arg1, A arg2, B arg3, C arg4)
    {
        Delegate temp_delegate;
        if (mEventGroup.TryGetValue(mEvenType, out temp_delegate))
        {
            MCallBack<T, A, B, C> mCallBack = temp_delegate as MCallBack<T, A, B, C>;
            if (mCallBack != null)
            {
                mCallBack(arg1, arg2, arg3, arg4);
            }
            else
            {
                throw new Exception(string.Format("广播事件错误：事件类型{0}对应的MCallBack具有不同的类型", mEvenType));
            }
        }
    }

    //5 parameters Broadcast
    public static void Broadcast<T, A, B, C, D>(MEvenType mEvenType, T arg1, A arg2, B arg3, C arg4, D arg5)
    {
        Delegate temp_delegate;
        if (mEventGroup.TryGetValue(mEvenType, out temp_delegate))
        {
            MCallBack<T, A, B, C, D> mCallBack = temp_delegate as MCallBack<T, A, B, C, D>;
            if (mCallBack != null)
            {
                mCallBack(arg1, arg2, arg3, arg4, arg5);
            }
            else
            {
                throw new Exception(string.Format("广播事件错误：事件类型{0}对应的MCallBack具有不同的类型", mEvenType));
            }
        }
    }

    //6 parameters Broadcast
    public static void Broadcast<T, A, B, C, D, E>(MEvenType mEvenType, T arg1, A arg2, B arg3, C arg4, D arg5, E arg6)
    {
        Delegate temp_delegate;
        if (mEventGroup.TryGetValue(mEvenType, out temp_delegate))
        {
            MCallBack<T, A, B, C, D, E> mCallBack = temp_delegate as MCallBack<T, A, B, C, D, E>;
            if (mCallBack != null)
            {
                mCallBack(arg1, arg2, arg3, arg4, arg5, arg6);
            }
            else
            {
                throw new Exception(string.Format("广播事件错误：事件类型{0}对应的MCallBack具有不同的类型", mEvenType));
            }
        }
    }

    //7 parameters Broadcast
    public static void Broadcast<T, A, B, C, D, E, F>(MEvenType mEvenType, T arg1, A arg2, B arg3, C arg4, D arg5, E arg6, F arg7)
    {
        Delegate temp_delegate;
        if (mEventGroup.TryGetValue(mEvenType, out temp_delegate))
        {
            MCallBack<T, A, B, C, D, E, F> mCallBack = temp_delegate as MCallBack<T, A, B, C, D, E, F>;
            if (mCallBack != null)
            {
                mCallBack(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            }
            else
            {
                throw new Exception(string.Format("广播事件错误：事件类型{0}对应的MCallBack具有不同的类型", mEvenType));
            }
        }
    }

    //8 parameters Broadcast
    public static void Broadcast<T, A, B, C, D, E, F, G>(MEvenType mEvenType, T arg1, A arg2, B arg3, C arg4, D arg5, E arg6, F arg7, G arg8)
    {
        Delegate temp_delegate;
        if (mEventGroup.TryGetValue(mEvenType, out temp_delegate))
        {
            MCallBack<T, A, B, C, D, E, F, G> mCallBack = temp_delegate as MCallBack<T, A, B, C, D, E, F, G>;
            if (mCallBack != null)
            {
                mCallBack(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            }
            else
            {
                throw new Exception(string.Format("广播事件错误：事件类型{0}对应的MCallBack具有不同的类型", mEvenType));
            }
        }
    }

    //9 parameters Broadcast
    public static void Broadcast<T, A, B, C, D, E, F, G, H>(MEvenType mEvenType, T arg1, A arg2, B arg3, C arg4, D arg5, E arg6, F arg7, G arg8, H arg9)
    {
        Delegate temp_delegate;
        if (mEventGroup.TryGetValue(mEvenType, out temp_delegate))
        {
            MCallBack<T, A, B, C, D, E, F, G, H> mCallBack = temp_delegate as MCallBack<T, A, B, C, D, E, F, G, H>;
            if (mCallBack != null)
            {
                mCallBack(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            }
            else
            {
                throw new Exception(string.Format("广播事件错误：事件类型{0}对应的MCallBack具有不同的类型", mEvenType));
            }
        }
    }
}
