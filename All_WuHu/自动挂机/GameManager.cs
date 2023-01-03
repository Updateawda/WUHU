
/********************************************************************************
 *	�ļ�����	GameManager.cs
 *	ȫ·����	\Script\GameManager\GameManager.cs
 *	�����ˣ�	���
 *	����ʱ�䣺2013-10-29
 *
 *	����˵������Ϸ������,������Ϸ��״̬�л���һЩȫ�ֱ�������
 *	         ����������Ϸ�����̿���
 *	         �ù�����Ϊ������������Ҫ��һ�������ٵ�GameObject
 *	         ע�⣺ֻ����Ϸȫ�̴��ڵĹ������ű����ڴˣ��Գ���Ϊ�����Ĺ�����һ�ɲ���Singleton<T>��ʽ����
 *	�޸ļ�¼��
*********************************************************************************/

using System.IO;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Games.GlobeDefine;
using Games;

public class GameManager : MonoBehaviour
{
    private GameManager()
    {
        /*m_ActiveScene = new ActiveScene();
        m_MissionManager = new MissionManager();
		m_TableManager = new TableManager();
        m_UILoadResource = new UILoadResource();*/
        m_PlayerDataPool = new PlayerData();
        //m_OtherPlayerData = new OtherPlayerData();
    }
    //public static int copyscenedifficult = 0;
    //   public static bool EnableMove  = true;
    public static GameManager gameManager = null;           //GameManager�Ե�����ʽ����
    //   //����shader
    //   public static Shader m_ShaderForStealth = null;
    //public static Shader m_ShaderForDissovle = null;
    //public static Shader m_ShaderOutLine = null;
    //   protected UILoadResource m_UILoadResource;
    //public static string m_DissovlePicPath="Texture/Mask_431";
    //   public UILoadResource UILoadResource
    //   {
    //       get { return m_UILoadResource; }
    //       set { m_UILoadResource = value; }
    //   }

    //   private SceneLogic m_SceneLogic;        //��ǰ����SceneLogic
    //   public Games.Scene.SceneLogic SceneLogic
    //   {
    //       get { return m_SceneLogic; }
    //       set { m_SceneLogic = value; }
    //   }

    ////��Ϸ��ǰ״̬
    //private GameDefine_Globe.GAMESTATUS m_GameStatus;
    //public GameDefine_Globe.GAMESTATUS GameStatus
    //{
    //    get { return m_GameStatus; }
    //    set { m_GameStatus = value; }
    //}

    //���ڴ�������״̬��������״̬
    //����״̬��Ҫ���ӷ�����
    //private bool m_bOnLineState = true;
    //public bool OnLineState
    //{
    //    get { return m_bOnLineState; }
    //    set { m_bOnLineState = value; }
    //}

    ////����ѡ��Ƿ���ʾ���Ƿ�����λ��
    //private bool m_bShowMainPlayerServerTrace = false;
    //public bool ShowMainPlayerServerTrace
    //{
    //    get { return m_bShowMainPlayerServerTrace; }
    //    set { m_bShowMainPlayerServerTrace = value; }
    //}

    ////////////////////////////////////////////////////////////////////////////
    /////����������,����ȫ�ֵĳ��������Ϣ
    ////////////////////////////////////////////////////////////////////////////
    //private ActiveScene m_ActiveScene;
    //public ActiveScene ActiveScene
    //{
    //    get { return m_ActiveScene; }
    //    set { m_ActiveScene = value; }
    //}

    ////////////////////////////////////////////////////////////////////////////
    /////���������
    ////////////////////////////////////////////////////////////////////////////
    //private MissionManager m_MissionManager;
    //public MissionManager MissionManager
    //{
    //    get { return m_MissionManager; }
    //}

    ////////////////////////////////////////////////////////////////////////////
    /////������
    ////////////////////////////////////////////////////////////////////////////
    //private TableManager m_TableManager;
    //public TableManager TableManager
    //{
    //    get { return m_TableManager; }
    //}

    ////////////////////////////////////////////////////////////////////////////
    ////����������
    ////////////////////////////////////////////////////////////////////////////
    //private SoundManager m_SoundManager;
    //public SoundManager SoundManager
    //{
    //    get { return m_SoundManager; }
    //    set { m_SoundManager = value; }
    //}


    ////////////////////////////////////////////////////////////////////////////
    ////��������� --��ʱ������
    ////////////////////////////////////////////////////////////////////////////
    //private NetManager m_NetManager;
    //public NetManager NetManager
    //{
    //    get { return m_NetManager; }
    //    set { m_NetManager = value; }
    //}

    //////////////////////////////////////////////////////////////////////////
    //��������Ϸ��һֱ���ڵ�����
    //////////////////////////////////////////////////////////////////////////
    private PlayerData m_PlayerDataPool;
    public PlayerData PlayerDataPool
    {
        get { return m_PlayerDataPool; }
        set { m_PlayerDataPool = value; }
    }
}

    //////////////////////////////////////////////////////////////////////////
    //������ҵ�����
    //////////////////////////////////////////////////////////////////////////
    //    private OtherPlayerData m_OtherPlayerData;
    //    public OtherPlayerData OtherPlayerData
    //    {
    //        get { return m_OtherPlayerData; }
    //        set { m_OtherPlayerData = value; }
    //    }

//    //////////////////////////////////////////////////////////////////////////
//    //�Զ�Ѱ·����
//    //////////////////////////////////////////////////////////////////////////
//    private AutoSearchAgent m_AutoSearch;
//    public AutoSearchAgent AutoSearch
//    {
//        get { return m_AutoSearch; }
//        set { m_AutoSearch = value; }
//    }

//    public int m_RunningScene = 0;
//    public int RunningScene
//    {
//        get { return m_RunningScene; }
//        set { m_RunningScene = value; }
//    }

//    /// <summary>
//    /// �Ƿ�Android�Ͷ˰档<= 512M || ˫��
//    /// </summary>
//    public bool IsLowAndroid = false;
//    public float m_NPCRefreshTime = 0.06f;//NPCˢ��ʱ��


//	public bool m_IsMj=false;//�Ƿ�����ͷ
//	// Awake
//	void Awake()
//	{
//        //ΪgameManager��ֵ�����е�����������Ҫ���ں���
//        if (null != gameManager)
//        {
//            Destroy(this.gameObject);
//        }		
//        gameManager = this;
//        DontDestroyOnLoad(this.gameObject);
//	}

//	// Use this for initialization
//	void Start ()
//    {
//        //���������
//        if (OnLineState == false)
//        {
//            InitGame();
//        }

//#if UNITY_ANDROID

//        if (SystemInfo.systemMemorySize < 768 || SystemInfo.processorCount < 2)
//        {
//            IsLowAndroid = true;
//            m_NPCRefreshTime = 0.09f;
//        }

//#endif
//    }
//	// Update is called once per frame
//	void Update () 
//	{
//         //�����¼�
//        Singleton<EventSystem>.GetInstance().UpdateDelayEventQueue();

//        //����ActiveScene
//        if (null != m_ActiveScene)
//        {
//            m_ActiveScene.Update();
//        }
//	}

//    //���״̬�ı�֮��ȫ�ֱ�����������Ϊ�������������׼��
//    //���÷�Χ������ҵ��ߣ��л���ɫ���л��ʺ�
//    public void PlayerStateChange()
//    {
//        //����PlayerDataPool
//        GameManager.gameManager.PlayerDataPool.CleanUp();
//		//Clean Damage Board
//		DamageBoardManager.ClearDamageDictionary();
//        //�����ʼ�����
//        MailData.CleanMailData();

//        PushNotification.ClearPushNotificationInfo();
//    }

//	public void InitGame()
//    {

//		if(!GlobeVar.s_FirstInitGame)
//		{
//			return;
//		}
//        if (false == InitGlobeManager())
//        {
//            LogModule.ErrorLog("Init Globe Manager Failed");
//        }

//        //��ʼ��ȫ�ֹ�����
//        m_SoundManager = this.gameObject.AddComponent<SoundManager>();

//        //����
//        m_NetManager = this.gameObject.AddComponent<NetManager>();

//        //�Զ�Ѱ·����
//        m_AutoSearch = this.gameObject.AddComponent<AutoSearchAgent>();

//        //Ĭ�Ͻ���Login״̬
//        //GameStatus = GameDefine_Globe.GAMESTATUS.GAMESTATUS_LOGIN;

//        //����Ϊ�ǵ�һ�ν�����Ϸ
//        GlobeVar.s_FirstInitGame = false;

//		//�����￪ʼ�����������
//		if(null != m_TableManager)
//		{
//			m_TableManager.InitTable();
//		}

//        //��������shader
//        if (m_ShaderForStealth ==null)
//	    {
//            m_ShaderForStealth = Shader.Find("Transparent/Diffuse");
//	    }
//		//��������shader
//		if (m_ShaderOutLine ==null)
//		{
//			m_ShaderOutLine = Shader.Find("MLDJ/OutLine");
//		}
//		//��������shader
//		if (m_ShaderForDissovle ==null)
//		{
//			m_ShaderForDissovle = Shader.Find("MLDJ/Dissolve_TexturCoords");
//		}
//	}

//    //��ʼ��ȫ�ֹ�����
//    bool InitGlobeManager()
//    {
//        bool bRet = true;

//        ////��ʼ��Scene Manager
//        //if (null != m_ActiveScene)
//        //{
//        //    bRet = m_ActiveScene.Init();
//        //    if (bRet)
//        //    {
//        //        LogModule.DebugLog("InitSceneManager OK");
//        //    }
//        //    else
//        //    {
//        //        LogModule.DebugLog("InitSceneManager Failed");
//        //    }
//        //}
//        //else
//        //{
//        //    LogModule.DebugLog("New SceneManager Failed");
//        //}

//        //��ʼ��EventSystem
//        Singleton<EventSystem>.GetInstance().Init();

//        return bRet;
//    }

//    // ����ʹ���첽�ص��� �����ǵ���Ŀ����������ƣ� �������룬������ע�͵���
//    public delegate void InitDataFinishDelegate();
//    public delegate void LoadRawDataFinishDelegate(byte[] bytes);

//    public LoadRawDataFinishDelegate rawDataCallback;
//    public InitDataFinishDelegate initDataCallback;

//    public void GetRawData(string strPath)
//    {
//        strRawPath = strPath;
//        StartCoroutine(GetWWWRawData());
//    }

//    private string strRawPath = "";
//    public WWW rawWWW = null;
//    public IEnumerator GetWWWRawData()
//    {
//        rawWWW = new WWW(strRawPath);
//        yield return rawWWW;

//        bool isError = string.IsNullOrEmpty(rawWWW.error);
//        if (!isError)
//        {
//            LogModule.DebugLog("Raw Data WWW Error" + rawWWW.url);
//        }

//        rawDataCallback(rawWWW.bytes);
//        initDataCallback();
//    }
//	public void ChangeTimeScal(float scale)
//	{
//		//if(m_IsMj==false)
//		Time.timeScale = scale;
//		Invoke ("ResetTimeScal", 0.5f);
//	}
//	public void ResetTimeScal()
//	{
//		Time.timeScale = 1.0f;
//	}
//}
